using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Security;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using static MyMathTool.ScriptGlobals;

namespace MyMathTool
{
    public partial class ProgrammingForm : Form
    {

        public Dictionary<int, int> bases = new Dictionary<int, int>();

        public ProgrammingForm()
        {
            InitializeComponent();
            numberingSysSelectBox.SelectedIndex = 0; // Default to decimal mode.
            bases.Add(0, 2); // Binary
            bases.Add(1, 16); // Hex
            bases.Add(2, 8); // Octal

            // Stop user from resizing.
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void ConvertDecimalRepresentation(object sender, EventArgs e)
        {
            TextBox invoked = (TextBox)sender;
            TextBox[] inputBoxes = new TextBox[] { binaryInput, hexInput, octalInput };

            if (invoked.Text == string.Empty)
            {
                foreach (TextBox inputBox in inputBoxes) inputBox.Text = string.Empty;
                return;
            }

            int value;
            if (int.TryParse(invoked.Text, out value))
            {
                if (value < 0) return;
                for (int i = 0; i < inputBoxes.Length; i++)
                {
                    inputBoxes[i].Text = Convert.ToString(Convert.ToInt64(value), bases[i]);
                }
            }
            else
            {
                try
                {
                    long parsedValue = long.Parse(invoked.Text);
                    if (parsedValue > int.MaxValue)
                    {
                        // Remove this and replace this with a more detailed message.
                        MessageBox.Show("Your inputed value is too large to calculate, convert, and represent in other numbering systems. Highest supported value is the maximum of standard 32-bit integers (2,147,483,647)", "Overflow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        invoked.Text = invoked.Text.Remove(invoked.Text.Length - 1);
                        invoked.Text = string.Empty;
                    }
                }
                catch (System.FormatException ex)
                {
                    MessageBox.Show("Your calculation contains a syntax error. Error: " + ex.Message, "Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    invoked.Text = string.Empty;
                }
            }
        }

        private void CopyBin(object sender, EventArgs e)
        {
            string bin = binaryInput.Text;
            System.Windows.Forms.Clipboard.SetText(bin);
            MessageBox.Show($"Binary string '{bin}' was copied to clipboard!", "Copied!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CopyHex(object sender, EventArgs e)
        {
            string hex = hexInput.Text;
            System.Windows.Forms.Clipboard.SetText(hex);
            MessageBox.Show($"Hexadecimal string '{hex}' was copied to clipboard!", "Copied!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CopyOctal(object sender, EventArgs e)
        {
            string octal = octalInput.Text;
            System.Windows.Forms.Clipboard.SetText(octal);
            MessageBox.Show($"Octal string '{octal}' was copied to clipboard!", "Copied!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RGBColorChangedEvent(object sender, EventArgs e)
        {
            int rVal = redValTrackBar.Value;
            int gVal = greenValTrackBar.Value;
            int bVal = blueValTrackBar.Value;

            colorPanel.BackColor = Color.FromArgb(rVal, gVal, bVal);

            hexColorCodeInput.Text = $"{Convert.ToString(Convert.ToInt64(rVal), 16)}{Convert.ToString(Convert.ToInt64(gVal), 16)}{Convert.ToString(Convert.ToInt64(bVal), 16)}";

            int[] hsl = Convert_RGB_HSL([rVal, gVal, bVal]);
            int h = hsl[0];
            int s = hsl[1];
            int l = hsl[2];

            redInput.Text = rVal.ToString();
            greenInput.Text = gVal.ToString();
            blueInput.Text = bVal.ToString();

            hueInput.Text = h.ToString();
            saturationInput.Text = s.ToString();
            lightnessInput.Text = l.ToString();
        }

        private double Max(double[] nums)
        {
            double max = nums[0]; // store previous max val.
            foreach (double num in nums)
            {
                if (num > max) max = num;
            }
            return max;
        }

        private double Min(double[] nums)
        {
            double min = nums[0]; // store previous min val.
            foreach (double num in nums)
            {
                if (num < min) min = num;
            }
            return min;
        }

        private int[] Convert_RGB_HSL(int[] RGBColorCode)
        {
            double r = RGBColorCode[0] / 255.0;
            double g = RGBColorCode[1] / 255.0;
            double b = RGBColorCode[2] / 255.0;

            double[] rgb = new double[] { r, g, b };

            double cmax = Max(rgb);
            double cmin = Min(rgb);
            double delta = cmax - cmin;

            double h = 0;
            double s = 0;
            double l = (cmax + cmin) / 2;

            // Calculate Hue
            if (delta == 0)
                h = 0;
            else if (cmax == r)
                h = 60 * (((g - b) / delta) % 6);
            else if (cmax == g)
                h = 60 * (((b - r) / delta) + 2);
            else if (cmax == b)
                h = 60 * (((r - g) / delta) + 4);

            if (h < 0) h += 360;

            // Calculate Saturation
            if (delta == 0)
                s = 0;
            else
                s = delta / (1 - Math.Abs(2 * l - 1));

            s *= 100;
            l *= 100;

            int[] hsl = new int[] { (int)Math.Round(h), (int)Math.Round(s), (int)Math.Round(l) };
            return hsl;
        }
        private void CopyRGBColorCode(object sender, EventArgs e)
        {
            string rgb = $"{redInput.Text}, {greenInput.Text}, {blueInput.Text}";
            System.Windows.Forms.Clipboard.SetText(rgb);
            MessageBox.Show($"RGB color code '{rgb}' was copied to clipboard!", "Copied!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CopyHexColorCode(object sender, EventArgs e)
        {
            string hex = hexColorCodeInput.Text;
            System.Windows.Forms.Clipboard.SetText(hex);
            MessageBox.Show($"Hexadecimal color code '{hex}' was copied to clipboard!", "Copied!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CopyHSLColorCode(object sender, EventArgs e)
        {
            string hsl = $"{hueInput.Text}, {saturationInput.Text}, {lightnessInput.Text}";
            System.Windows.Forms.Clipboard.SetText(hsl);
            MessageBox.Show($"HSL color code '{hsl}' was copied to clipboard!", "Copied!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AppendToCalculationString(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            Button btn = (Button)sender;
            if (!string.IsNullOrEmpty(programmingResultBox.Text))
            {
                if (programmingResultBox.Text[programmingResultBox.Text.Length - 1] == '.' && btn.Text == ".")
                {
                    return;
                }
            }
            programmingResultBox.Text += btn.Text;
        }
        private void RemoveLastChar(object sender, EventArgs e)
        {
            string currentText = programmingResultBox.Text;
            if (string.IsNullOrEmpty(currentText)) return;
            int lastCharIndex = programmingResultBox.Text.Length - 1;
            programmingResultBox.Text = currentText.Remove(lastCharIndex);
        }
        private void NumberingSysChangeEvent(object sender, EventArgs e)
        {

            programmingResultBox.Text = string.Empty;

            // Decimal - 0
            // Binary - 1
            // Hexidecimal - 2
            // Octal - 3

            Button[] numBtns = new Button[] { numBtn0, numBtn1, numBtn2, numBtn3, numBtn4, numBtn5, numBtn6, numBtn7, numBtn8, numBtn9, numBtnA, numBtnB, numBtnC, numBtnD, numBtnE, numBtnF };

            switch (numberingSysSelectBox.SelectedIndex)
            {
                case 0:
                    foreach (Button btn in numBtns)
                    {
                        if (Regex.IsMatch(btn.Text, @"^\d+$")) btn.Enabled = true;
                        else btn.Enabled = false;
                    }
                    break;
                case 1:
                    foreach (Button btn in numBtns)
                    {
                        if (btn.Text == "1" || btn.Text == "0") btn.Enabled = true;
                        else btn.Enabled = false;
                    }
                    break;
                case 2:
                    foreach (Button btn in numBtns)
                    {
                        if (Regex.IsMatch(btn.Text, @"^[0-9A-Fa-f]+$")) btn.Enabled = true;
                        else btn.Enabled = false; // This should not ever be triggered.. Leaving for when I add more numbering systems.
                    }
                    break;
                case 3:
                    foreach (Button btn in numBtns)
                    {
                        if (Regex.IsMatch(btn.Text, @"^[0-7]+$")) btn.Enabled = true;
                        else btn.Enabled = false;
                    }
                    break;
            }
        }

        private void EvaluateExpression(object sender, EventArgs e)
        {
            // Decimal - 0
            // Binary - 1
            // Hexidecimal - 2
            // Octal - 3

            DataTable dt = new DataTable();

            switch (numberingSysSelectBox.SelectedIndex)
            {
                case 0:

                    var result = dt.Compute(programmingResultBox.Text, null);

                    decInput.Text = result.ToString();

                    break;

                case 1:
                    var binPattern = new Regex(@"\b[01]+\b");

                    string binToDec = binPattern.Replace(programmingResultBox.Text, match =>
                    {
                        int dec = Convert.ToInt32(match.Value, 2);
                        return dec.ToString();
                    });

                    var binResult = dt.Compute(binToDec, null);

                    decInput.Text = binResult.ToString();

                    break;

                case 2:

                    var hexPattern = new Regex(@"\b[0-9A-Fa-f]+\b");

                    string hexToDec = hexPattern.Replace(programmingResultBox.Text, match =>
                    {
                        int dec = Convert.ToInt32(match.Value, 16);
                        return dec.ToString();
                    });

                    var hexResult = dt.Compute(hexToDec, null);

                    decInput.Text = hexResult.ToString();

                    break;

                case 3:

                    var octPattern = new Regex(@"\b[0-7]+\b");

                    string octToDec = octPattern.Replace(programmingResultBox.Text, match =>
                    {
                        int dec = Convert.ToInt32(match.Value, 8);
                        return dec.ToString();
                    });

                    var octResult = dt.Compute(octToDec, null);

                    decInput.Text = octResult.ToString();

                    break;
            }
        }

        private void ClearEntry(object sender, EventArgs e)
        {
            programmingResultBox.Text = string.Empty;
        }

        private void ClearAll(object sender, EventArgs e)
        {
            programmingResultBox.Text = string.Empty;
            decInput.Text = string.Empty;
            binaryInput.Text = string.Empty;
            hexInput.Text = string.Empty;
            octalInput.Text = string.Empty;
        }

        private void InsertLogicGate(object sender, EventArgs e)
        {
            // This method also inserts 1, 0, and commas
            Button btn = (Button)sender;

            int caretIndex = logicalOperatorsTextArea.SelectionStart;
            int lineIndex = logicalOperatorsTextArea.GetLineFromCharIndex(caretIndex);
            int lineStartIndex = logicalOperatorsTextArea.GetFirstCharIndexFromLine(lineIndex);
            int caretOffsetInLine = caretIndex - lineStartIndex;

            string[] lines = logicalOperatorsTextArea.Lines;

            if (lineIndex >= lines.Length)
            {
                Array.Resize(ref lines, lineIndex + 1);
                lines[lineIndex] = "";
            }

            lines[lineIndex] = lines[lineIndex].Insert(caretOffsetInLine, $"{btn.Text}()");

            logicalOperatorsTextArea.Lines = lines;
        }

        private async Task RunLogic(string[] lines)
        {
            List<string> results = new List<string>();

            var globals = new ScriptGlobals { Form = this };

            var scriptOptions = ScriptOptions.Default
                .WithReferences(Assembly.GetExecutingAssembly())
                .WithImports("System", "System.Linq", "MyMathTool");

            foreach (string line in lines)
            {
                try
                {
                    var script = CSharpScript.Create<object>($"ScriptGlobals.{line}", scriptOptions, typeof(ScriptGlobals));
                    var result = await script.RunAsync(globals);
                    
                    results.Add(result.ReturnValue?.ToString() ?? "null");
                }
                catch (Exception ex)
                {
                    results.Add($"Compile Time Error: An error has occurred while compiling your logic code. Perhaps you forgot a needed argument?");
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            ReturnLogicOutput(results.ToArray());
        }

        private void ReturnLogicOutput(string[] results)
        {
            outputTextArea.Clear();
            foreach (string result in results)
            {
                outputTextArea.AppendText($"{result}\r\n");
            }
        }

        private async void Run(object sender, EventArgs e)
        {
            await RunLogic(logicalOperatorsTextArea.Lines);
        }
    }
}
