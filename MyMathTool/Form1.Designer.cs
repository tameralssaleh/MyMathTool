namespace MyMathTool
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitAltF4ToolStripMenuItem = new ToolStripMenuItem();
            openProjectToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            calculatorsToolStripMenuItem = new ToolStripMenuItem();
            financeToolStripMenuItem = new ToolStripMenuItem();
            trigonometryToolStripMenuItem = new ToolStripMenuItem();
            graphingToolStripMenuItem = new ToolStripMenuItem();
            programmingToolStripMenuItem = new ToolStripMenuItem();
            logicalToolStripMenuItem = new ToolStripMenuItem();
            compilerToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            version100ToolStripMenuItem = new ToolStripMenuItem();
            guideToolStripMenuItem = new ToolStripMenuItem();
            reportBugsToolStripMenuItem = new ToolStripMenuItem();
            gitHubToolStripMenuItem = new ToolStripMenuItem();
            theMMTProjectToolStripMenuItem = new ToolStripMenuItem();
            historyBox = new ListBox();
            addBtn = new Button();
            resultBox = new TextBox();
            subBtn = new Button();
            mulBtn = new Button();
            divBtn = new Button();
            evalBtn = new Button();
            numBtn9 = new Button();
            numBtn8 = new Button();
            numBtn7 = new Button();
            numBtn4 = new Button();
            numBtn5 = new Button();
            numBtn6 = new Button();
            numBtn1 = new Button();
            numBtn2 = new Button();
            numBtn3 = new Button();
            numBtn0 = new Button();
            decimalBtn = new Button();
            rightParaBtn = new Button();
            LeftParaBtn = new Button();
            clearHistBtn = new Button();
            copyBtn = new Button();
            saveCalcsToFileBtn = new Button();
            footerLabel = new Label();
            squareBtn = new Button();
            expBtn = new Button();
            sqrtBtn = new Button();
            multiplicativeInverseBtn = new Button();
            switchSignBtn = new Button();
            backBtn = new Button();
            clearBtn = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolsToolStripMenuItem, settingsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(552, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitAltF4ToolStripMenuItem, openProjectToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitAltF4ToolStripMenuItem
            // 
            exitAltF4ToolStripMenuItem.Name = "exitAltF4ToolStripMenuItem";
            exitAltF4ToolStripMenuItem.Size = new Size(144, 22);
            exitAltF4ToolStripMenuItem.Text = "Exit (Alt + F4)";
            exitAltF4ToolStripMenuItem.Click += Exit;
            // 
            // openProjectToolStripMenuItem
            // 
            openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            openProjectToolStripMenuItem.Size = new Size(144, 22);
            openProjectToolStripMenuItem.Text = "Open Project";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculatorsToolStripMenuItem, compilerToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(47, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // calculatorsToolStripMenuItem
            // 
            calculatorsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { financeToolStripMenuItem, trigonometryToolStripMenuItem, graphingToolStripMenuItem, programmingToolStripMenuItem, logicalToolStripMenuItem });
            calculatorsToolStripMenuItem.Name = "calculatorsToolStripMenuItem";
            calculatorsToolStripMenuItem.Size = new Size(133, 22);
            calculatorsToolStripMenuItem.Text = "Calculators";
            // 
            // financeToolStripMenuItem
            // 
            financeToolStripMenuItem.Name = "financeToolStripMenuItem";
            financeToolStripMenuItem.Size = new Size(148, 22);
            financeToolStripMenuItem.Text = "Finance";
            financeToolStripMenuItem.Click += OpenFinanceCalculator;
            // 
            // trigonometryToolStripMenuItem
            // 
            trigonometryToolStripMenuItem.Name = "trigonometryToolStripMenuItem";
            trigonometryToolStripMenuItem.Size = new Size(148, 22);
            trigonometryToolStripMenuItem.Text = "Trigonometry";
            // 
            // graphingToolStripMenuItem
            // 
            graphingToolStripMenuItem.Name = "graphingToolStripMenuItem";
            graphingToolStripMenuItem.Size = new Size(148, 22);
            graphingToolStripMenuItem.Text = "Graphing";
            graphingToolStripMenuItem.Click += OpenGraphingChartingForm;
            // 
            // programmingToolStripMenuItem
            // 
            programmingToolStripMenuItem.Name = "programmingToolStripMenuItem";
            programmingToolStripMenuItem.Size = new Size(148, 22);
            programmingToolStripMenuItem.Text = "Programming";
            programmingToolStripMenuItem.Click += OpenProgrammingCalculator;
            // 
            // logicalToolStripMenuItem
            // 
            logicalToolStripMenuItem.Name = "logicalToolStripMenuItem";
            logicalToolStripMenuItem.Size = new Size(148, 22);
            logicalToolStripMenuItem.Text = "Logical";
            // 
            // compilerToolStripMenuItem
            // 
            compilerToolStripMenuItem.Name = "compilerToolStripMenuItem";
            compilerToolStripMenuItem.Size = new Size(133, 22);
            compilerToolStripMenuItem.Text = "Compiler";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { version100ToolStripMenuItem, guideToolStripMenuItem, reportBugsToolStripMenuItem, gitHubToolStripMenuItem, theMMTProjectToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // version100ToolStripMenuItem
            // 
            version100ToolStripMenuItem.Name = "version100ToolStripMenuItem";
            version100ToolStripMenuItem.Size = new Size(166, 22);
            version100ToolStripMenuItem.Text = "Version 1.0.0";
            // 
            // guideToolStripMenuItem
            // 
            guideToolStripMenuItem.Name = "guideToolStripMenuItem";
            guideToolStripMenuItem.Size = new Size(166, 22);
            guideToolStripMenuItem.Text = "Guide";
            // 
            // reportBugsToolStripMenuItem
            // 
            reportBugsToolStripMenuItem.Name = "reportBugsToolStripMenuItem";
            reportBugsToolStripMenuItem.Size = new Size(166, 22);
            reportBugsToolStripMenuItem.Text = "Report Bugs";
            // 
            // gitHubToolStripMenuItem
            // 
            gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            gitHubToolStripMenuItem.Size = new Size(166, 22);
            gitHubToolStripMenuItem.Text = "GitHub";
            // 
            // theMMTProjectToolStripMenuItem
            // 
            theMMTProjectToolStripMenuItem.Name = "theMMTProjectToolStripMenuItem";
            theMMTProjectToolStripMenuItem.Size = new Size(166, 22);
            theMMTProjectToolStripMenuItem.Text = "The MMT Project";
            // 
            // historyBox
            // 
            historyBox.FormattingEnabled = true;
            historyBox.Location = new Point(12, 37);
            historyBox.Name = "historyBox";
            historyBox.Size = new Size(198, 364);
            historyBox.TabIndex = 1;
            // 
            // addBtn
            // 
            addBtn.Cursor = Cursors.Hand;
            addBtn.Font = new Font("Segoe UI", 18F);
            addBtn.Location = new Point(480, 77);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(60, 60);
            addBtn.TabIndex = 2;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += AppendToCalculationString;
            // 
            // resultBox
            // 
            resultBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultBox.Location = new Point(216, 33);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(324, 35);
            resultBox.TabIndex = 3;
            resultBox.TextAlign = HorizontalAlignment.Right;
            resultBox.TextChanged += CheckCalculationString;
            // 
            // subBtn
            // 
            subBtn.Cursor = Cursors.Hand;
            subBtn.Font = new Font("Segoe UI", 18F);
            subBtn.Location = new Point(480, 143);
            subBtn.Name = "subBtn";
            subBtn.Size = new Size(60, 60);
            subBtn.TabIndex = 4;
            subBtn.Text = "-";
            subBtn.UseVisualStyleBackColor = true;
            subBtn.Click += AppendToCalculationString;
            // 
            // mulBtn
            // 
            mulBtn.Cursor = Cursors.Hand;
            mulBtn.Font = new Font("Segoe UI", 18F);
            mulBtn.Location = new Point(480, 209);
            mulBtn.Name = "mulBtn";
            mulBtn.Size = new Size(60, 60);
            mulBtn.TabIndex = 5;
            mulBtn.Text = "*";
            mulBtn.UseVisualStyleBackColor = true;
            mulBtn.Click += AppendToCalculationString;
            // 
            // divBtn
            // 
            divBtn.Cursor = Cursors.Hand;
            divBtn.Font = new Font("Segoe UI", 18F);
            divBtn.Location = new Point(480, 275);
            divBtn.Name = "divBtn";
            divBtn.Size = new Size(60, 60);
            divBtn.TabIndex = 6;
            divBtn.Text = "/";
            divBtn.UseVisualStyleBackColor = true;
            divBtn.Click += AppendToCalculationString;
            // 
            // evalBtn
            // 
            evalBtn.Cursor = Cursors.Hand;
            evalBtn.Font = new Font("Segoe UI", 18F);
            evalBtn.Location = new Point(480, 341);
            evalBtn.Name = "evalBtn";
            evalBtn.Size = new Size(60, 60);
            evalBtn.TabIndex = 7;
            evalBtn.Text = "=";
            evalBtn.UseVisualStyleBackColor = true;
            evalBtn.Click += EvaulateCalculation;
            // 
            // numBtn9
            // 
            numBtn9.Cursor = Cursors.Hand;
            numBtn9.Font = new Font("Segoe UI", 18F);
            numBtn9.Location = new Point(414, 77);
            numBtn9.Name = "numBtn9";
            numBtn9.Size = new Size(60, 60);
            numBtn9.TabIndex = 8;
            numBtn9.Text = "9";
            numBtn9.UseVisualStyleBackColor = true;
            numBtn9.Click += AppendToCalculationString;
            // 
            // numBtn8
            // 
            numBtn8.Cursor = Cursors.Hand;
            numBtn8.Font = new Font("Segoe UI", 18F);
            numBtn8.Location = new Point(348, 77);
            numBtn8.Name = "numBtn8";
            numBtn8.Size = new Size(60, 60);
            numBtn8.TabIndex = 9;
            numBtn8.Text = "8";
            numBtn8.UseVisualStyleBackColor = true;
            numBtn8.Click += AppendToCalculationString;
            // 
            // numBtn7
            // 
            numBtn7.Cursor = Cursors.Hand;
            numBtn7.Font = new Font("Segoe UI", 18F);
            numBtn7.Location = new Point(282, 77);
            numBtn7.Name = "numBtn7";
            numBtn7.Size = new Size(60, 60);
            numBtn7.TabIndex = 10;
            numBtn7.Text = "7";
            numBtn7.UseVisualStyleBackColor = true;
            numBtn7.Click += AppendToCalculationString;
            // 
            // numBtn4
            // 
            numBtn4.Cursor = Cursors.Hand;
            numBtn4.Font = new Font("Segoe UI", 18F);
            numBtn4.Location = new Point(282, 143);
            numBtn4.Name = "numBtn4";
            numBtn4.Size = new Size(60, 60);
            numBtn4.TabIndex = 11;
            numBtn4.Text = "4";
            numBtn4.UseVisualStyleBackColor = true;
            numBtn4.Click += AppendToCalculationString;
            // 
            // numBtn5
            // 
            numBtn5.Cursor = Cursors.Hand;
            numBtn5.Font = new Font("Segoe UI", 18F);
            numBtn5.Location = new Point(348, 143);
            numBtn5.Name = "numBtn5";
            numBtn5.Size = new Size(60, 60);
            numBtn5.TabIndex = 12;
            numBtn5.Text = "5";
            numBtn5.UseVisualStyleBackColor = true;
            numBtn5.Click += AppendToCalculationString;
            // 
            // numBtn6
            // 
            numBtn6.Cursor = Cursors.Hand;
            numBtn6.Font = new Font("Segoe UI", 18F);
            numBtn6.Location = new Point(414, 143);
            numBtn6.Name = "numBtn6";
            numBtn6.Size = new Size(60, 60);
            numBtn6.TabIndex = 13;
            numBtn6.Text = "6";
            numBtn6.UseVisualStyleBackColor = true;
            numBtn6.Click += AppendToCalculationString;
            // 
            // numBtn1
            // 
            numBtn1.Cursor = Cursors.Hand;
            numBtn1.Font = new Font("Segoe UI", 18F);
            numBtn1.Location = new Point(282, 209);
            numBtn1.Name = "numBtn1";
            numBtn1.Size = new Size(60, 60);
            numBtn1.TabIndex = 14;
            numBtn1.Text = "1";
            numBtn1.UseVisualStyleBackColor = true;
            numBtn1.Click += AppendToCalculationString;
            // 
            // numBtn2
            // 
            numBtn2.Cursor = Cursors.Hand;
            numBtn2.Font = new Font("Segoe UI", 18F);
            numBtn2.Location = new Point(348, 209);
            numBtn2.Name = "numBtn2";
            numBtn2.Size = new Size(60, 60);
            numBtn2.TabIndex = 15;
            numBtn2.Text = "2";
            numBtn2.UseVisualStyleBackColor = true;
            numBtn2.Click += AppendToCalculationString;
            // 
            // numBtn3
            // 
            numBtn3.Cursor = Cursors.Hand;
            numBtn3.Font = new Font("Segoe UI", 18F);
            numBtn3.Location = new Point(414, 209);
            numBtn3.Name = "numBtn3";
            numBtn3.Size = new Size(60, 60);
            numBtn3.TabIndex = 16;
            numBtn3.Text = "3";
            numBtn3.UseVisualStyleBackColor = true;
            numBtn3.Click += AppendToCalculationString;
            // 
            // numBtn0
            // 
            numBtn0.Cursor = Cursors.Hand;
            numBtn0.Font = new Font("Segoe UI", 18F);
            numBtn0.Location = new Point(348, 275);
            numBtn0.Name = "numBtn0";
            numBtn0.Size = new Size(60, 60);
            numBtn0.TabIndex = 17;
            numBtn0.Text = "0";
            numBtn0.UseVisualStyleBackColor = true;
            numBtn0.Click += AppendToCalculationString;
            // 
            // decimalBtn
            // 
            decimalBtn.Cursor = Cursors.Hand;
            decimalBtn.Font = new Font("Segoe UI", 18F);
            decimalBtn.Location = new Point(414, 275);
            decimalBtn.Name = "decimalBtn";
            decimalBtn.Size = new Size(60, 60);
            decimalBtn.TabIndex = 18;
            decimalBtn.Text = ".";
            decimalBtn.UseVisualStyleBackColor = true;
            decimalBtn.Click += AppendToCalculationString;
            // 
            // rightParaBtn
            // 
            rightParaBtn.Cursor = Cursors.Hand;
            rightParaBtn.Font = new Font("Segoe UI", 18F);
            rightParaBtn.Location = new Point(282, 275);
            rightParaBtn.Name = "rightParaBtn";
            rightParaBtn.Size = new Size(60, 60);
            rightParaBtn.TabIndex = 19;
            rightParaBtn.Text = ")";
            rightParaBtn.UseVisualStyleBackColor = true;
            rightParaBtn.Click += AppendToCalculationString;
            // 
            // LeftParaBtn
            // 
            LeftParaBtn.Cursor = Cursors.Hand;
            LeftParaBtn.Font = new Font("Segoe UI", 18F);
            LeftParaBtn.Location = new Point(216, 275);
            LeftParaBtn.Name = "LeftParaBtn";
            LeftParaBtn.Size = new Size(60, 60);
            LeftParaBtn.TabIndex = 20;
            LeftParaBtn.Text = "(";
            LeftParaBtn.UseVisualStyleBackColor = true;
            LeftParaBtn.Click += AppendToCalculationString;
            // 
            // clearHistBtn
            // 
            clearHistBtn.Cursor = Cursors.Hand;
            clearHistBtn.Location = new Point(81, 403);
            clearHistBtn.Name = "clearHistBtn";
            clearHistBtn.Size = new Size(60, 40);
            clearHistBtn.TabIndex = 21;
            clearHistBtn.Text = "Clear History";
            clearHistBtn.UseVisualStyleBackColor = true;
            clearHistBtn.Click += ClearHistory;
            // 
            // copyBtn
            // 
            copyBtn.Cursor = Cursors.Hand;
            copyBtn.Location = new Point(150, 403);
            copyBtn.Name = "copyBtn";
            copyBtn.Size = new Size(60, 40);
            copyBtn.TabIndex = 22;
            copyBtn.Text = "Copy";
            copyBtn.UseVisualStyleBackColor = true;
            copyBtn.Click += CopyFromHistory;
            // 
            // saveCalcsToFileBtn
            // 
            saveCalcsToFileBtn.Cursor = Cursors.Hand;
            saveCalcsToFileBtn.Location = new Point(12, 403);
            saveCalcsToFileBtn.Name = "saveCalcsToFileBtn";
            saveCalcsToFileBtn.Size = new Size(60, 40);
            saveCalcsToFileBtn.TabIndex = 23;
            saveCalcsToFileBtn.Text = "Save";
            saveCalcsToFileBtn.UseVisualStyleBackColor = true;
            // 
            // footerLabel
            // 
            footerLabel.AutoSize = true;
            footerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            footerLabel.Location = new Point(246, 428);
            footerLabel.Name = "footerLabel";
            footerLabel.Size = new Size(294, 15);
            footerLabel.TabIndex = 24;
            footerLabel.Text = "MyMathTool | Version 1.0.0 | Written by Tamer Alssaleh";
            // 
            // squareBtn
            // 
            squareBtn.Cursor = Cursors.Hand;
            squareBtn.Font = new Font("Segoe UI", 18F);
            squareBtn.Location = new Point(216, 77);
            squareBtn.Name = "squareBtn";
            squareBtn.Size = new Size(60, 60);
            squareBtn.TabIndex = 25;
            squareBtn.Text = "x²";
            squareBtn.UseVisualStyleBackColor = true;
            squareBtn.Click += SquareInput;
            // 
            // expBtn
            // 
            expBtn.Cursor = Cursors.Hand;
            expBtn.Font = new Font("Segoe UI", 18F);
            expBtn.Location = new Point(216, 143);
            expBtn.Name = "expBtn";
            expBtn.Size = new Size(60, 60);
            expBtn.TabIndex = 26;
            expBtn.Text = "xʸ";
            expBtn.UseVisualStyleBackColor = true;
            expBtn.Click += ToggleCaret;
            // 
            // sqrtBtn
            // 
            sqrtBtn.Cursor = Cursors.Hand;
            sqrtBtn.Font = new Font("Segoe UI", 18F);
            sqrtBtn.Location = new Point(216, 209);
            sqrtBtn.Name = "sqrtBtn";
            sqrtBtn.Size = new Size(60, 60);
            sqrtBtn.TabIndex = 27;
            sqrtBtn.Text = "√x";
            sqrtBtn.UseVisualStyleBackColor = true;
            // 
            // multiplicativeInverseBtn
            // 
            multiplicativeInverseBtn.Cursor = Cursors.Hand;
            multiplicativeInverseBtn.Font = new Font("Segoe UI", 18F);
            multiplicativeInverseBtn.Location = new Point(348, 341);
            multiplicativeInverseBtn.Name = "multiplicativeInverseBtn";
            multiplicativeInverseBtn.Size = new Size(60, 60);
            multiplicativeInverseBtn.TabIndex = 28;
            multiplicativeInverseBtn.Text = "x⁻¹";
            multiplicativeInverseBtn.UseVisualStyleBackColor = true;
            // 
            // switchSignBtn
            // 
            switchSignBtn.Cursor = Cursors.Hand;
            switchSignBtn.Font = new Font("Segoe UI", 18F);
            switchSignBtn.Location = new Point(414, 341);
            switchSignBtn.Name = "switchSignBtn";
            switchSignBtn.Size = new Size(60, 60);
            switchSignBtn.TabIndex = 29;
            switchSignBtn.Text = "+/-";
            switchSignBtn.UseVisualStyleBackColor = true;
            switchSignBtn.Click += SwitchSign;
            // 
            // backBtn
            // 
            backBtn.Cursor = Cursors.Hand;
            backBtn.Font = new Font("Segoe UI", 18F);
            backBtn.Location = new Point(282, 341);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(60, 60);
            backBtn.TabIndex = 30;
            backBtn.Text = "←";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += RemoveLastFromCalculationString;
            // 
            // clearBtn
            // 
            clearBtn.Cursor = Cursors.Hand;
            clearBtn.Font = new Font("Segoe UI", 18F);
            clearBtn.Location = new Point(216, 341);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(60, 60);
            clearBtn.TabIndex = 31;
            clearBtn.Text = "C";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += ClearResultBox;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 458);
            Controls.Add(clearBtn);
            Controls.Add(backBtn);
            Controls.Add(switchSignBtn);
            Controls.Add(multiplicativeInverseBtn);
            Controls.Add(sqrtBtn);
            Controls.Add(expBtn);
            Controls.Add(squareBtn);
            Controls.Add(footerLabel);
            Controls.Add(saveCalcsToFileBtn);
            Controls.Add(copyBtn);
            Controls.Add(clearHistBtn);
            Controls.Add(LeftParaBtn);
            Controls.Add(rightParaBtn);
            Controls.Add(decimalBtn);
            Controls.Add(numBtn0);
            Controls.Add(numBtn3);
            Controls.Add(numBtn2);
            Controls.Add(numBtn1);
            Controls.Add(numBtn6);
            Controls.Add(numBtn5);
            Controls.Add(numBtn4);
            Controls.Add(numBtn7);
            Controls.Add(numBtn8);
            Controls.Add(numBtn9);
            Controls.Add(evalBtn);
            Controls.Add(divBtn);
            Controls.Add(mulBtn);
            Controls.Add(subBtn);
            Controls.Add(resultBox);
            Controls.Add(addBtn);
            Controls.Add(historyBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(568, 497);
            MinimumSize = new Size(568, 497);
            Name = "Main";
            Text = "MyMathTool";
            KeyDown += KeyDownListener;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ListBox historyBox;
        private Button addBtn;
        private TextBox resultBox;
        private Button subBtn;
        private Button mulBtn;
        private Button divBtn;
        private Button evalBtn;
        private Button numBtn9;
        private Button numBtn8;
        private Button numBtn7;
        private Button numBtn4;
        private Button numBtn5;
        private Button numBtn6;
        private Button numBtn1;
        private Button numBtn2;
        private Button numBtn3;
        private Button numBtn0;
        private Button decimalBtn;
        private Button rightParaBtn;
        private Button LeftParaBtn;
        private Button clearHistBtn;
        private Button copyBtn;
        private Button saveCalcsToFileBtn;
        private Label footerLabel;
        private Button squareBtn;
        private Button expBtn;
        private Button sqrtBtn;
        private Button multiplicativeInverseBtn;
        private Button switchSignBtn;
        private Button backBtn;
        private Button clearBtn;
        private ToolStripMenuItem exitAltF4ToolStripMenuItem;
        private ToolStripMenuItem calculatorsToolStripMenuItem;
        private ToolStripMenuItem financeToolStripMenuItem;
        private ToolStripMenuItem programmingToolStripMenuItem;
        private ToolStripMenuItem trigonometryToolStripMenuItem;
        private ToolStripMenuItem version100ToolStripMenuItem;
        private ToolStripMenuItem guideToolStripMenuItem;
        private ToolStripMenuItem reportBugsToolStripMenuItem;
        private ToolStripMenuItem gitHubToolStripMenuItem;
        private ToolStripMenuItem theMMTProjectToolStripMenuItem;
        private ToolStripMenuItem graphingToolStripMenuItem;
        private ToolStripMenuItem logicalToolStripMenuItem;
        private ToolStripMenuItem openProjectToolStripMenuItem;
        private ToolStripMenuItem compilerToolStripMenuItem;
    }
}
