namespace MyMathTool
{
    partial class FinancialForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            taxGroupBox = new GroupBox();
            taxOutput = new TextBox();
            dollarSignLabel2 = new Label();
            percentSignLabel1 = new Label();
            dollarSignLabel1 = new Label();
            calculateTaxBtn = new Button();
            taxPercentInput = new TextBox();
            taxPercentILabel = new Label();
            amtInput = new TextBox();
            amountLabel = new Label();
            ciGroupBox = new GroupBox();
            CIOutput = new TextBox();
            dollarSign4 = new Label();
            timesPerPeriodInput = new TextBox();
            calculateCIBtn = new Button();
            appliedInterestNSignLabel = new Label();
            appliedInterestNLabel = new Label();
            elapsedTimeInput = new TextBox();
            tTimeSignLabel = new Label();
            tTimeLabel = new Label();
            percentSignLabel2 = new Label();
            dollarSignLabel3 = new Label();
            interestRateInput = new TextBox();
            interestRatePercentILabel = new Label();
            formulaLabel1 = new Label();
            principalInput = new TextBox();
            amountLabel2 = new Label();
            taxGroupBox.SuspendLayout();
            ciGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // taxGroupBox
            // 
            taxGroupBox.Controls.Add(taxOutput);
            taxGroupBox.Controls.Add(dollarSignLabel2);
            taxGroupBox.Controls.Add(percentSignLabel1);
            taxGroupBox.Controls.Add(dollarSignLabel1);
            taxGroupBox.Controls.Add(calculateTaxBtn);
            taxGroupBox.Controls.Add(taxPercentInput);
            taxGroupBox.Controls.Add(taxPercentILabel);
            taxGroupBox.Controls.Add(amtInput);
            taxGroupBox.Controls.Add(amountLabel);
            taxGroupBox.Location = new Point(20, 12);
            taxGroupBox.Name = "taxGroupBox";
            taxGroupBox.Size = new Size(261, 157);
            taxGroupBox.TabIndex = 0;
            taxGroupBox.TabStop = false;
            taxGroupBox.Text = "Tax";
            // 
            // taxOutput
            // 
            taxOutput.Location = new Point(123, 114);
            taxOutput.Name = "taxOutput";
            taxOutput.Size = new Size(108, 23);
            taxOutput.TabIndex = 8;
            // 
            // dollarSignLabel2
            // 
            dollarSignLabel2.AutoSize = true;
            dollarSignLabel2.Font = new Font("Segoe UI", 11F);
            dollarSignLabel2.Location = new Point(105, 114);
            dollarSignLabel2.Name = "dollarSignLabel2";
            dollarSignLabel2.Size = new Size(17, 20);
            dollarSignLabel2.TabIndex = 7;
            dollarSignLabel2.Text = "$";
            // 
            // percentSignLabel1
            // 
            percentSignLabel1.AutoSize = true;
            percentSignLabel1.Font = new Font("Segoe UI", 11F);
            percentSignLabel1.Location = new Point(34, 81);
            percentSignLabel1.Name = "percentSignLabel1";
            percentSignLabel1.Size = new Size(21, 20);
            percentSignLabel1.TabIndex = 6;
            percentSignLabel1.Text = "%";
            // 
            // dollarSignLabel1
            // 
            dollarSignLabel1.AutoSize = true;
            dollarSignLabel1.Font = new Font("Segoe UI", 11F);
            dollarSignLabel1.Location = new Point(34, 37);
            dollarSignLabel1.Name = "dollarSignLabel1";
            dollarSignLabel1.Size = new Size(17, 20);
            dollarSignLabel1.TabIndex = 5;
            dollarSignLabel1.Text = "$";
            // 
            // calculateTaxBtn
            // 
            calculateTaxBtn.Cursor = Cursors.Hand;
            calculateTaxBtn.Location = new Point(30, 110);
            calculateTaxBtn.Name = "calculateTaxBtn";
            calculateTaxBtn.Size = new Size(69, 31);
            calculateTaxBtn.TabIndex = 4;
            calculateTaxBtn.Text = "Calculate";
            calculateTaxBtn.UseVisualStyleBackColor = true;
            calculateTaxBtn.Click += CalculateTaxes;
            // 
            // taxPercentInput
            // 
            taxPercentInput.Location = new Point(57, 81);
            taxPercentInput.Name = "taxPercentInput";
            taxPercentInput.Size = new Size(174, 23);
            taxPercentInput.TabIndex = 3;
            // 
            // taxPercentILabel
            // 
            taxPercentILabel.AutoSize = true;
            taxPercentILabel.Location = new Point(30, 63);
            taxPercentILabel.Name = "taxPercentILabel";
            taxPercentILabel.Size = new Size(201, 15);
            taxPercentILabel.TabIndex = 2;
            taxPercentILabel.Text = "Tax Rate (in percentage e.g. 7 for 7%)";
            // 
            // amtInput
            // 
            amtInput.Location = new Point(57, 37);
            amtInput.Name = "amtInput";
            amtInput.Size = new Size(174, 23);
            amtInput.TabIndex = 1;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(30, 19);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(174, 15);
            amountLabel.TabIndex = 0;
            amountLabel.Text = "Amount (Gross, Sub Total, etc..)";
            // 
            // ciGroupBox
            // 
            ciGroupBox.Controls.Add(CIOutput);
            ciGroupBox.Controls.Add(dollarSign4);
            ciGroupBox.Controls.Add(timesPerPeriodInput);
            ciGroupBox.Controls.Add(calculateCIBtn);
            ciGroupBox.Controls.Add(appliedInterestNSignLabel);
            ciGroupBox.Controls.Add(appliedInterestNLabel);
            ciGroupBox.Controls.Add(elapsedTimeInput);
            ciGroupBox.Controls.Add(tTimeSignLabel);
            ciGroupBox.Controls.Add(tTimeLabel);
            ciGroupBox.Controls.Add(percentSignLabel2);
            ciGroupBox.Controls.Add(dollarSignLabel3);
            ciGroupBox.Controls.Add(interestRateInput);
            ciGroupBox.Controls.Add(interestRatePercentILabel);
            ciGroupBox.Controls.Add(formulaLabel1);
            ciGroupBox.Controls.Add(principalInput);
            ciGroupBox.Controls.Add(amountLabel2);
            ciGroupBox.Location = new Point(20, 175);
            ciGroupBox.Name = "ciGroupBox";
            ciGroupBox.Size = new Size(261, 355);
            ciGroupBox.TabIndex = 9;
            ciGroupBox.TabStop = false;
            ciGroupBox.Text = "Interest";
            // 
            // CIOutput
            // 
            CIOutput.Location = new Point(123, 291);
            CIOutput.Name = "CIOutput";
            CIOutput.Size = new Size(108, 23);
            CIOutput.TabIndex = 11;
            // 
            // dollarSign4
            // 
            dollarSign4.AutoSize = true;
            dollarSign4.Font = new Font("Segoe UI", 11F);
            dollarSign4.Location = new Point(105, 291);
            dollarSign4.Name = "dollarSign4";
            dollarSign4.Size = new Size(17, 20);
            dollarSign4.TabIndex = 10;
            dollarSign4.Text = "$";
            // 
            // timesPerPeriodInput
            // 
            timesPerPeriodInput.Location = new Point(57, 247);
            timesPerPeriodInput.Name = "timesPerPeriodInput";
            timesPerPeriodInput.Size = new Size(174, 23);
            timesPerPeriodInput.TabIndex = 17;
            // 
            // calculateCIBtn
            // 
            calculateCIBtn.Cursor = Cursors.Hand;
            calculateCIBtn.Location = new Point(30, 287);
            calculateCIBtn.Name = "calculateCIBtn";
            calculateCIBtn.Size = new Size(69, 31);
            calculateCIBtn.TabIndex = 9;
            calculateCIBtn.Text = "Calculate";
            calculateCIBtn.UseVisualStyleBackColor = true;
            calculateCIBtn.Click += CalculateCompoundInterest;
            // 
            // appliedInterestNSignLabel
            // 
            appliedInterestNSignLabel.AutoSize = true;
            appliedInterestNSignLabel.Location = new Point(37, 250);
            appliedInterestNSignLabel.Name = "appliedInterestNSignLabel";
            appliedInterestNSignLabel.Size = new Size(17, 15);
            appliedInterestNSignLabel.TabIndex = 16;
            appliedInterestNSignLabel.Text = "n:";
            // 
            // appliedInterestNLabel
            // 
            appliedInterestNLabel.AutoSize = true;
            appliedInterestNLabel.Location = new Point(34, 223);
            appliedInterestNLabel.Name = "appliedInterestNLabel";
            appliedInterestNLabel.Size = new Size(174, 15);
            appliedInterestNLabel.TabIndex = 15;
            appliedInterestNLabel.Text = "Applied interest per time period";
            // 
            // elapsedTimeInput
            // 
            elapsedTimeInput.Location = new Point(57, 194);
            elapsedTimeInput.Name = "elapsedTimeInput";
            elapsedTimeInput.Size = new Size(174, 23);
            elapsedTimeInput.TabIndex = 14;
            // 
            // tTimeSignLabel
            // 
            tTimeSignLabel.AutoSize = true;
            tTimeSignLabel.Location = new Point(37, 197);
            tTimeSignLabel.Name = "tTimeSignLabel";
            tTimeSignLabel.Size = new Size(14, 15);
            tTimeSignLabel.TabIndex = 13;
            tTimeSignLabel.Text = "t:";
            // 
            // tTimeLabel
            // 
            tTimeLabel.AutoSize = true;
            tTimeLabel.Location = new Point(34, 170);
            tTimeLabel.Name = "tTimeLabel";
            tTimeLabel.Size = new Size(119, 15);
            tTimeLabel.TabIndex = 12;
            tTimeLabel.Text = "Time periods elapsed";
            // 
            // percentSignLabel2
            // 
            percentSignLabel2.AutoSize = true;
            percentSignLabel2.Font = new Font("Segoe UI", 11F);
            percentSignLabel2.Location = new Point(34, 144);
            percentSignLabel2.Name = "percentSignLabel2";
            percentSignLabel2.Size = new Size(21, 20);
            percentSignLabel2.TabIndex = 11;
            percentSignLabel2.Text = "%";
            // 
            // dollarSignLabel3
            // 
            dollarSignLabel3.AutoSize = true;
            dollarSignLabel3.Font = new Font("Segoe UI", 11F);
            dollarSignLabel3.Location = new Point(34, 98);
            dollarSignLabel3.Name = "dollarSignLabel3";
            dollarSignLabel3.Size = new Size(17, 20);
            dollarSignLabel3.TabIndex = 11;
            dollarSignLabel3.Text = "$";
            // 
            // interestRateInput
            // 
            interestRateInput.Location = new Point(57, 144);
            interestRateInput.Name = "interestRateInput";
            interestRateInput.Size = new Size(174, 23);
            interestRateInput.TabIndex = 10;
            // 
            // interestRatePercentILabel
            // 
            interestRatePercentILabel.AutoSize = true;
            interestRatePercentILabel.Location = new Point(30, 126);
            interestRatePercentILabel.Name = "interestRatePercentILabel";
            interestRatePercentILabel.Size = new Size(223, 15);
            interestRatePercentILabel.TabIndex = 9;
            interestRatePercentILabel.Text = "Interest Rate (in percentage e.g. 7 for 7%)";
            // 
            // formulaLabel1
            // 
            formulaLabel1.AutoSize = true;
            formulaLabel1.Font = new Font("Segoe UI", 16F);
            formulaLabel1.Location = new Point(46, 44);
            formulaLabel1.Name = "formulaLabel1";
            formulaLabel1.Size = new Size(158, 30);
            formulaLabel1.TabIndex = 0;
            formulaLabel1.Text = "A=P(1+r/n​)^nt";
            // 
            // principalInput
            // 
            principalInput.Location = new Point(57, 98);
            principalInput.Name = "principalInput";
            principalInput.Size = new Size(174, 23);
            principalInput.TabIndex = 10;
            // 
            // amountLabel2
            // 
            amountLabel2.AutoSize = true;
            amountLabel2.Location = new Point(30, 80);
            amountLabel2.Name = "amountLabel2";
            amountLabel2.Size = new Size(149, 15);
            amountLabel2.TabIndex = 9;
            amountLabel2.Text = "Principal (starting amount)";
            // 
            // FinancialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 542);
            Controls.Add(ciGroupBox);
            Controls.Add(taxGroupBox);
            Name = "FinancialForm";
            Text = "Finance Calculator";
            taxGroupBox.ResumeLayout(false);
            taxGroupBox.PerformLayout();
            ciGroupBox.ResumeLayout(false);
            ciGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox taxGroupBox;
        private Label taxPercentILabel;
        private TextBox amtInput;
        private Label amountLabel;
        private TextBox taxPercentInput;
        private Label percentSignLabel1;
        private Label dollarSignLabel1;
        private Button calculateTaxBtn;
        private TextBox taxOutput;
        private Label dollarSignLabel2;
        private GroupBox ciGroupBox;
        private Label formulaLabel1;
        private Label tTimeSignLabel;
        private Label tTimeLabel;
        private Label percentSignLabel2;
        private Label dollarSignLabel3;
        private TextBox interestRateInput;
        private Label interestRatePercentILabel;
        private TextBox principalInput;
        private Label amountLabel2;
        private TextBox CIOutput;
        private Label dollarSign4;
        private TextBox timesPerPeriodInput;
        private Button calculateCIBtn;
        private Label appliedInterestNSignLabel;
        private Label appliedInterestNLabel;
        private TextBox elapsedTimeInput;
    }
}