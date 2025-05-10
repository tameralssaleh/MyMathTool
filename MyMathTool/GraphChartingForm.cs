using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;
using ScottPlot.Interactivity.UserActionResponses;
using ScottPlot.WinForms;
using static System.Math;

namespace MyMathTool
{
    public partial class GraphChartingForm : Form
    {

        public GraphChartingForm()
        {
            InitializeComponent();
            // Add a vertical line at X = 0
            var originX = plotGraph.Plot.Add.VerticalLine(0);
            originX.Color = Colors.Black;
            originX.LineWidth = 1;  // thickness

            // Add a horizontal line at Y = 0
            var originY = plotGraph.Plot.Add.HorizontalLine(0);
            originY.Color = Colors.Black;
            originY.LineWidth = 1;  // thickness

            plotGraph.Plot.Axes.SetLimits(-10, 10, -10, 10);

            // Stop user from resizing.
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void SetGraphConstraints(double leftX, double rightX, double bottomY, double topY)
        {
            // Set graph viewport to user's liking.
            plotGraph.Plot.Axes.SetLimits(leftX, rightX, bottomY, topY);
            plotGraph.Refresh();
        }

        private void SetGraphTickSizes(double x, double y)
        {
            // Set tick markers for x and y axes.
            plotGraph.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericFixedInterval(x);
            plotGraph.Plot.Axes.Left.TickGenerator = new ScottPlot.TickGenerators.NumericFixedInterval(y);
            plotGraph.Refresh();
        }
        private string SuperscriptToNormal(string superscript)
        {
            return superscript
                .Replace("⁰", "0")
                .Replace("¹", "1")
                .Replace("²", "2")
                .Replace("³", "3")
                .Replace("⁴", "4")
                .Replace("⁵", "5")
                .Replace("⁶", "6")
                .Replace("⁷", "7")
                .Replace("⁸", "8")
                .Replace("⁹", "9");
        }

        private double EvaluateFunction(string func, double inputValue)
        {
            func = func.Replace(" ", "");

            if (func.Contains('='))
            {
                string[] splitFunc = func.Split('=');
                if (splitFunc.Length != 2)
                    return double.NaN;

                string preparedFunc = splitFunc[1];

                preparedFunc = Regex.Replace(preparedFunc, @"(?<=[0-9])(?=[a-zA-Z])", "*");

                // Handle exponential equations
                preparedFunc = Regex.Replace(preparedFunc, @"([0-9])ˣ", "(Math.Pow($1, x))"); // returns "3^x"

                // Handle exponents with coefficents .
                preparedFunc = Regex.Replace(preparedFunc, @"(?<!\w)([0-9]+)\*?([a-zA-Z])([⁰¹²³⁴⁵⁶⁷⁸⁹]+)", match =>
                {
                    string coeff = match.Groups[1].Value;
                    string variable = match.Groups[2].Value;
                    string superscript = match.Groups[3].Value;
                    string exponent = SuperscriptToNormal(superscript);
                    return $"({coeff}*Math.Pow({variable}, {exponent}))";
                });

                // Handle standalone variable with exponent (e.g., x² -> Math.Pow(x, 2))
                preparedFunc = Regex.Replace(preparedFunc, @"([a-zA-Z])([⁰¹²³⁴⁵⁶⁷⁸⁹]+)", match =>
                {
                    string variable = match.Groups[1].Value;
                    string superscript = match.Groups[2].Value;
                    string exponent = SuperscriptToNormal(superscript);
                    return $"(Math.Pow({variable}, {exponent}))";
                });

                // Handle logarithmic functions
                preparedFunc = Regex.Replace(preparedFunc, @"\blog\s*\(([^)]+)\)", "Math.Log10($1)");
                preparedFunc = Regex.Replace(preparedFunc, @"\bln\s*\(([^)]+)\)", "Math.Log($1)");

                // Handle Trigonometic functions
                preparedFunc = Regex.Replace(preparedFunc, @"\bsin\s*\(([^)]+)\)", "Math.Sin($1)");
                preparedFunc = Regex.Replace(preparedFunc, @"\bcos\s*\(([^)]+)\)", "Math.Cos($1)");

                // Replace 'x' with actual number 
                preparedFunc = Regex.Replace(preparedFunc, @"\bx\b",inputValue % 1 == 0 ? $"({inputValue.ToString(CultureInfo.InvariantCulture)}.0)" : $"({inputValue.ToString(CultureInfo.InvariantCulture)})");
                try
                {
                    double result = Evaluator.EvaluateExpressionAsync(preparedFunc).GetAwaiter().GetResult();
                    if (double.IsInfinity(result)) return double.NaN;
                    else return result;
                }
                catch
                {
                    return double.NaN;
                    //MessageBox.Show($"Your expression tried to be compiled but had a fatal error. \nExpression: {preparedFunc}");
                }
            }
            return double.NaN;
        }

        private void SetGraphConfig(object sender, EventArgs e)
        {
            double xLeft = Convert.ToDouble(xRangeLeftInput.Text);
            double xRight = Convert.ToDouble(xRangeRightInput.Text);
            double yBottom = Convert.ToDouble(yRangeBottomInput.Text);
            double yTop = Convert.ToDouble(yRangeTopInput.Text);
            double xTick = Convert.ToDouble(xTickInput.Text);
            double yTick = Convert.ToDouble(yTickInput.Text);
            // Set graph boundaries.
            SetGraphConstraints(xLeft, xRight, yBottom, yTop);
            SetGraphTickSizes(xTick, yTick);
        }

        private void GenerateGraph(string function)
        {
            outputLogConsole.Text = string.Empty;
            DateTime now;
            now = DateTime.Now; // Get time at start of execution.
            outputLogConsole.AppendText($"Rendering function at {now.Hour}:{now.Minute}:{now.Second}.\n");
            outputLogConsole.AppendText($"Function: '{function}'\n");

            int count = functionInputsList.Items.Cast<string>().Count(f => f == function);  

            // Clear rows table to prevent incorrect values.
            pairsTable.Rows.Clear();
            List<double> xs = new List<double>();
            List<double> ys = new List<double>();

            int min = -5;
            int max = 5;
            int tickMultiplier = 2;

            bool isLogarithmic = Regex.IsMatch(function, @"\blog\s*\(") || Regex.IsMatch(function, @"\bln\s*\(");
            bool isSinoid = Regex.IsMatch(function, @"\bsin\s*\(") || Regex.IsMatch(function, @"\bcos\s*\(");

            // Check if function is a logarithmic function.
            if (isLogarithmic)
            {
                min = 0;
                max = 10;
                tickMultiplier = 4;
                outputLogConsole.AppendText("WARNING: Function appears to be logarithmic and requires more points to render a curve. This may result in a slightly longer rendering time.\n");
            }
            // Check if function is a sinoid function.
            if (isSinoid)
            {
                min = -10;
                max = 10;
                tickMultiplier = 4;
                outputLogConsole.AppendText("WARNING: Function appears to be sinusoidal and requires more points to render a curve. This may result in longer rendering times.\n");
            }

            int steps = (max - min) * tickMultiplier;
            for (int i = min * 2; i <= steps; i++)
            {
                double xVal = (double)i / tickMultiplier;
                xs.Add(xVal);
                double yVal = EvaluateFunction(function, xVal);
                ys.Add(yVal);
            }

            for (int j = 0; j < xs.Count; j++)
            {
                if (xs[j] % 1 == 0) pairsTable.Rows.Add(xs[j], double.IsNaN(ys[j]) || double.IsInfinity(ys[j]) ? "Undefined" : ys[j]);
            }

            outputLogConsole.AppendText($"Plotted {xs.Count} x, y points.\n");

            // Clear plot first before adding new curve.
            plotGraph.Plot.Clear();

            // Add a vertical line at X = 0
            var originX = plotGraph.Plot.Add.VerticalLine(0);
            originX.Color = Colors.Black;
            originX.LineWidth = 1;  // thickness

            // Add a horizontal line at Y = 0
            var originY = plotGraph.Plot.Add.HorizontalLine(0);
            originY.Color = Colors.Black;
            originY.LineWidth = 1;  // thickness
            plotGraph.Plot.Add.Scatter(xs, ys);
            plotGraph.Refresh();
            if (count == 1) return; // Return if the function was already stored before to prevent duplicate function entry.
            functionInputsList.Items.Add(function);

            now = DateTime.Now;
            outputLogConsole.AppendText($"Finished rendering at {now.Hour}:{now.Minute}:{now.Second}.\n");
        }

        private void InsertFunction(object sender, EventArgs e)
        {
            string function = functionInput.Text;
            GenerateGraph(function);
        }

        private void ComputeValueFunction(object sender, EventArgs e)
        {
            try
            {
                string function = functionInputsList.Items[functionInputsList.SelectedIndex].ToString();
                double x = Convert.ToDouble(functionValueInput.Text);
                double y = EvaluateFunction(function, x);
                pairsTable.Rows.Add(x, y);
            }
            catch(System.ArgumentOutOfRangeException ex)
            {
                outputLogConsole.Text = string.Empty;
                outputLogConsole.AppendText($"Error Message: \n >>> {ex.Message}\n");
                outputLogConsole.AppendText("Potential Cause: \n >>> This error may have occurred due to no function being selected while trying to calculate a value from a function.\n");
                outputLogConsole.AppendText("Potential Fix: \n >>> Select a function in the function selector box (top left corner) before entering a value and clicking 'Calculate'.\n");
                outputLogConsole.AppendText(">>> If you believe this may have been a bug, please click 'Report Bug' and follow further instructions.");
            }

        }
        private void GraphSelectedFunction(object sender, EventArgs e)
        {
            string function = functionInputsList.Items[functionInputsList.SelectedIndex].ToString();
            GenerateGraph(function);
        }

        private void ClearGraph(object sender, EventArgs e)
        {
            // Clear graph data.
            plotGraph.Plot.Clear();
            pairsTable.Rows.Clear();

            // Keep origin lines.
            var originX = plotGraph.Plot.Add.VerticalLine(0);
            originX.Color = Colors.Black;
            originX.LineWidth = 1;

            var originY = plotGraph.Plot.Add.HorizontalLine(0);
            originY.Color = Colors.Black;
            originY.LineWidth = 1;

            plotGraph.Refresh();
        }
        private void ClearAll(object sender, EventArgs e)
        {
            // Clear graph data.
            plotGraph.Plot.Clear();
            functionInputsList.Items.Clear();
            functionInput.Text = string.Empty;

            // Clear table data.
            pairsTable.Rows.Clear();
            functionValueInput.Text = string.Empty;


            // Keep origin lines.
            var originX = plotGraph.Plot.Add.VerticalLine(0);
            originX.Color = Colors.Black;
            originX.LineWidth = 1;

            var originY = plotGraph.Plot.Add.HorizontalLine(0);
            originY.Color = Colors.Black;
            originY.LineWidth = 1;

            plotGraph.Refresh();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}