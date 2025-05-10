using System.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace MyMathTool
{
    public partial class Main : Form
    {

        public bool activeCaret = false;

        public Dictionary<char, char> superscriptMap = new Dictionary<char, char>
        {
            ['¹'] = '1',
            ['²'] = '2',
            ['³'] = '3',
            ['⁴'] = '4',
            ['⁵'] = '5',
            ['⁶'] = '6',
            ['⁷'] = '7',
            ['⁸'] = '8',
            ['⁹'] = '9',
            ['⁰'] = '0'
        };

        public Dictionary<char, char> expMap = new Dictionary<char, char>
        {
            ['1'] = '¹',
            ['2'] = '²',
            ['3'] = '³',
            ['4'] = '⁴',
            ['5'] = '⁵',
            ['6'] = '⁶',
            ['7'] = '⁷',
            ['8'] = '⁸',
            ['9'] = '⁹',
            ['0'] = '⁰'
        };


        public Dictionary<char, double> mathSymbols = new Dictionary<char, double>
        {
            ['π'] = Math.PI,
            ['τ'] = Math.Tau,
            ['φ'] = (1 + Math.Sqrt(5) / 2)
        };

        public Main()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }

        private void AppendToCalculationString(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            Button btn = (Button)sender;
            if (!string.IsNullOrEmpty(resultBox.Text))
            {
                if (resultBox.Text[resultBox.Text.Length - 1] == '.' && btn.Text == ".")
                {
                    return;
                }
            }
            resultBox.Text += this.activeCaret ? expMap[btn.Text.ToCharArray()[0]] : btn.Text;
        }

        private void AppendToCalculationString_KeyDown(char character)
        {
            if (!string.IsNullOrEmpty(resultBox.Text))
            {
                if (resultBox.Text[resultBox.Text.Length - 1] == '.' && character == '.')
                {
                    return;
                }
            }
            resultBox.Text += this.activeCaret ? expMap[character] : character;
        }

        private void EvaulateCalculation(object? sender, EventArgs? e)
        {
            this.ActiveControl = null;
            string calculation = resultBox.Text;
            if (string.IsNullOrEmpty(calculation)) return;

            // Parse and interpret superscripts
            string parsedExpression = Regex.Replace(calculation, @"\(?-?\d+\)?[⁰¹²³⁴⁵⁶⁷⁸⁹]+", match =>
            {
                string term = match.Value;
                StringBuilder baseBuilder = new StringBuilder();
                StringBuilder exponentBuilder = new StringBuilder();

                bool isParenthesized = term.StartsWith("(") && term.Contains(")");

                foreach (char c in term)
                {
                    if (superscriptMap.ContainsKey(c)) exponentBuilder.Append(superscriptMap[c]);
                    else if (char.IsDigit(c) || c == '-' || c == '.') baseBuilder.Append(c); // Support for decimals 
                }

                double baseNum = double.Parse(baseBuilder.ToString());
                double exponentNum = double.Parse(exponentBuilder.ToString());

                // Apply special logic only if NOT parenthesized
                bool isInteger = exponentNum % 1 == 0;
                bool isEven = isInteger && ((long)exponentNum % 2 == 0);

                if (!isParenthesized && isEven && baseNum < 0)
                    baseNum *= -1;

                double result = Math.Pow(baseNum, exponentNum);

                return result.ToString();
            });

            DataTable dt = new DataTable();
            try
            {
                var result = dt.Compute($"({parsedExpression})", null);
                resultBox.Text = result.ToString();
                // Use Replace(" ", "") method to remove any accidental or unintended white spaces.
                historyBox.Items.Add(calculation.Replace(" ", "") + " | " + result.ToString().Replace(" ", ""));
            }
            catch (System.Data.SyntaxErrorException ex)
            {
                DialogResult result = MessageBox.Show("Your calculation contains a syntax error: " + ex.Message, "Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    resultBox.Text = string.Empty;
                }
            }
            catch (System.Data.EvaluateException ex)
            {
                DialogResult result = MessageBox.Show($"An error has occurred while evaluating. \nMessage: {ex.Message}", "Evaluation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    resultBox.Text = string.Empty;
                } 
            }
        }
        private void ClearHistory(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            DialogResult conf = MessageBox.Show("Are you sure you want to clear your history?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (conf != DialogResult.Yes) return;
            historyBox.Items.Clear();
        }

        private void CopyFromHistory(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            string fullCalculation = historyBox.SelectedItem.ToString().Replace(" ", "");
            string[] split = fullCalculation.Split('|');
            string left = split[0];
            resultBox.Text = left;
        }

        private void CheckCalculationString(object sender, EventArgs e)
        {
            if (resultBox.Text.Length == 0) return;

            char[] symbols = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.', '+', '-', '*', '/', '(', ')', '¹', '²', '³', '⁴', '⁵', '⁶', '⁷', '⁸', '⁹', '⁰', 'E' };

            char lastEnteredChar = resultBox.Text[resultBox.Text.Length - 1];

            if (!symbols.Contains(lastEnteredChar))
            {
                resultBox.Text = resultBox.Text.Remove(resultBox.Text.Length - 1);
                resultBox.SelectionStart = resultBox.Text.Length;
            }

        }

        private void KeyDownListener(object sender, KeyEventArgs e)
        {
            if (resultBox.Focused) return; // Prevents double insertion.
            switch (e.KeyCode)
            {
                case Keys.D0:
                    AppendToCalculationString_KeyDown(e.Shift ? ')' : '0');
                    break;
                case Keys.D1:
                    AppendToCalculationString_KeyDown('1');
                    break;
                case Keys.D2:
                    AppendToCalculationString_KeyDown('2');
                    break;
                case Keys.D3:
                    AppendToCalculationString_KeyDown('3');
                    break;
                case Keys.D4:
                    AppendToCalculationString_KeyDown('4');
                    break;
                case Keys.D5:
                    AppendToCalculationString_KeyDown('5');
                    break;
                case Keys.D6:
                    AppendToCalculationString_KeyDown('6');
                    break;
                case Keys.D7:
                    AppendToCalculationString_KeyDown('7');
                    break;
                case Keys.D8:
                    AppendToCalculationString_KeyDown(e.Shift ? '*' : '8');
                    break;
                case Keys.D9:
                    AppendToCalculationString_KeyDown(e.Shift ? '(' : '9');
                    break;
                case Keys.Add:
                    AppendToCalculationString_KeyDown('+');
                    break;
                case Keys.Subtract:
                    AppendToCalculationString_KeyDown('-');
                    break;
                case Keys.Multiply:
                    AppendToCalculationString_KeyDown('*');
                    break;
                case Keys.Divide:
                    AppendToCalculationString_KeyDown('/');
                    break;
                case Keys.Decimal:
                    AppendToCalculationString_KeyDown('.');
                    break;
                // Enter triggers evaluation button.
                case Keys.Enter:
                    EvaulateCalculation(null, null);
                    break;
                // Remove last character from calc string.
                case Keys.Back:
                    RemoveLastFromCalculationString(null, null);
                    break;
            }
            /*
            * CONTROL
            */
            if (e.Alt && e.KeyCode == Keys.F4) Exit(null, null); // Works on most keyboards
        }

        private void ClearResultBox(object sender, EventArgs e)
        {
            resultBox.Clear();
        }

        private void RemoveLastFromCalculationString(object? sender, EventArgs? e)
        {
            string currentText = resultBox.Text;
            if (string.IsNullOrEmpty(currentText)) return;
            int lastCharIndex = resultBox.Text.Length - 1;
            resultBox.Text = currentText.Remove(lastCharIndex);
        }

        private void SwitchSign(object sender, EventArgs e)
        {
            resultBox.Text = (double.Parse(resultBox.Text) * -1).ToString();
        }

        private void ToggleCaret(object sender, EventArgs e)
        {
            // Toggle on/off caret mode (on = insert exponent)
            this.activeCaret = !this.activeCaret;
            this.Text = this.activeCaret ? "MyMathTool - Caret ON" : "MyMathTool";
        }

        private void Exit(object? sender, EventArgs? e)
        {
            this.Close();
        }

        private void SquareInput(object sender, EventArgs e)
        {
            resultBox.Text += "²";
        }

        // Forms

        private void OpenProgrammingCalculator(object sender, EventArgs e)
        {
            ProgrammingForm form = new ProgrammingForm();
            form.ShowDialog();
        }

        private void OpenFinanceCalculator(object sender, EventArgs e)
        {
            FinancialForm form = new FinancialForm();
            form.ShowDialog();
        }

        private void OpenGraphingChartingForm(object sender, EventArgs e)
        {
            GraphChartingForm form = new GraphChartingForm();
            form.ShowDialog();
        }

    }
}

