using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MyMathTool
{
    public partial class FinancialForm : Form
    {
        public FinancialForm()
        {
            InitializeComponent();
        }

        private void CalculateTaxes(object sender, EventArgs e)
        {
            // Tax
            decimal amt;
            decimal taxRate;
            if (Decimal.TryParse(amtInput.Text, out amt) && Decimal.TryParse(taxPercentInput.Text, out taxRate))
            {
                taxOutput.Text = (amt + (amt * (taxRate / 100))).ToString();
            }
            else
            {
                MessageBox.Show("An invalid value was entered in a field.", "Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateCompoundInterest(object sender, EventArgs e)
        {
            // Compound interest 
            decimal principal;
            decimal interestRate;
            decimal n;
            decimal t;
            if (Decimal.TryParse(principalInput.Text, out principal) && Decimal.TryParse(interestRateInput.Text, out interestRate) && Decimal.TryParse(timesPerPeriodInput.Text, out n) && Decimal.TryParse(elapsedTimeInput.Text, out t)) 
            {
                interestRate /= 100;
                decimal result = (decimal)Math.Round(((double)principal * Math.Pow(((double)1 + (double)interestRate / (double)n), ((double)n * (double)t))), 2);
                CIOutput.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("An invalid value was entered in a field.", "Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
