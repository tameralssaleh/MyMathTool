namespace MyMathTool
{
    partial class GraphChartingForm
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
            plotGraph = new ScottPlot.WinForms.FormsPlot();
            graphSettingsGroupBox = new GroupBox();
            yTickInput = new TextBox();
            xTickInput = new TextBox();
            yTickLabel = new Label();
            xTickLabel = new Label();
            xyStepLabel = new Label();
            setGraphConfigBtn = new Button();
            yRangeTopInput = new TextBox();
            yRangeBottomInput = new TextBox();
            yGraphRangeLabel = new Label();
            xRangeRightInput = new TextBox();
            xRangeLeftInput = new TextBox();
            xGraphRangeLabel = new Label();
            functionInputsList = new ListBox();
            pairsTable = new DataGridView();
            Input = new DataGridViewTextBoxColumn();
            Output = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openGraphToolStripMenuItem = new ToolStripMenuItem();
            projectToolStripMenuItem = new ToolStripMenuItem();
            graphToolStripMenuItem1 = new ToolStripMenuItem();
            datasetToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            clearGraphsToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            insertToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            functionToolStripMenuItem = new ToolStripMenuItem();
            createFunctionToolStripMenuItem = new ToolStripMenuItem();
            trigonometricToolStripMenuItem = new ToolStripMenuItem();
            sinToolStripMenuItem = new ToolStripMenuItem();
            cosToolStripMenuItem = new ToolStripMenuItem();
            tanToolStripMenuItem = new ToolStripMenuItem();
            secToolStripMenuItem = new ToolStripMenuItem();
            cscToolStripMenuItem = new ToolStripMenuItem();
            cotToolStripMenuItem = new ToolStripMenuItem();
            sinhToolStripMenuItem = new ToolStripMenuItem();
            coshToolStripMenuItem = new ToolStripMenuItem();
            tanhToolStripMenuItem = new ToolStripMenuItem();
            cscToolStripMenuItem1 = new ToolStripMenuItem();
            cschToolStripMenuItem = new ToolStripMenuItem();
            cothToolStripMenuItem = new ToolStripMenuItem();
            sincToolStripMenuItem = new ToolStripMenuItem();
            logarithmicToolStripMenuItem = new ToolStripMenuItem();
            log10ToolStripMenuItem = new ToolStripMenuItem();
            logbToolStripMenuItem = new ToolStripMenuItem();
            lnToolStripMenuItem = new ToolStripMenuItem();
            exponentialToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            eˣToolStripMenuItem = new ToolStripMenuItem();
            bˣToolStripMenuItem = new ToolStripMenuItem();
            constraintToolStripMenuItem = new ToolStripMenuItem();
            graphToolStripMenuItem = new ToolStripMenuItem();
            functionInput = new TextBox();
            insertFunctionBtn = new Button();
            clearGraphsBtn = new Button();
            funcLabel = new Label();
            computeFunctionalValBtn = new Button();
            functionValueInput = new TextBox();
            button1 = new Button();
            button2 = new Button();
            outputLogConsole = new RichTextBox();
            outputDebugGroupBox = new GroupBox();
            reportBugBtn = new Button();
            clearConsoleBtn = new Button();
            graphSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pairsTable).BeginInit();
            menuStrip1.SuspendLayout();
            outputDebugGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // plotGraph
            // 
            plotGraph.DisplayScale = 1F;
            plotGraph.Location = new Point(732, 27);
            plotGraph.Name = "plotGraph";
            plotGraph.Size = new Size(600, 600);
            plotGraph.TabIndex = 0;
            // 
            // graphSettingsGroupBox
            // 
            graphSettingsGroupBox.Controls.Add(yTickInput);
            graphSettingsGroupBox.Controls.Add(xTickInput);
            graphSettingsGroupBox.Controls.Add(yTickLabel);
            graphSettingsGroupBox.Controls.Add(xTickLabel);
            graphSettingsGroupBox.Controls.Add(xyStepLabel);
            graphSettingsGroupBox.Controls.Add(setGraphConfigBtn);
            graphSettingsGroupBox.Controls.Add(yRangeTopInput);
            graphSettingsGroupBox.Controls.Add(yRangeBottomInput);
            graphSettingsGroupBox.Controls.Add(yGraphRangeLabel);
            graphSettingsGroupBox.Controls.Add(xRangeRightInput);
            graphSettingsGroupBox.Controls.Add(xRangeLeftInput);
            graphSettingsGroupBox.Controls.Add(xGraphRangeLabel);
            graphSettingsGroupBox.Location = new Point(732, 640);
            graphSettingsGroupBox.Name = "graphSettingsGroupBox";
            graphSettingsGroupBox.Size = new Size(600, 182);
            graphSettingsGroupBox.TabIndex = 1;
            graphSettingsGroupBox.TabStop = false;
            graphSettingsGroupBox.Text = "Configure Graph";
            // 
            // yTickInput
            // 
            yTickInput.Location = new Point(134, 99);
            yTickInput.Name = "yTickInput";
            yTickInput.Size = new Size(78, 23);
            yTickInput.TabIndex = 11;
            yTickInput.Text = "1";
            // 
            // xTickInput
            // 
            xTickInput.Location = new Point(37, 99);
            xTickInput.Name = "xTickInput";
            xTickInput.Size = new Size(78, 23);
            xTickInput.TabIndex = 10;
            xTickInput.Text = "1";
            // 
            // yTickLabel
            // 
            yTickLabel.AutoSize = true;
            yTickLabel.Font = new Font("Segoe UI", 11F);
            yTickLabel.Location = new Point(115, 99);
            yTickLabel.Name = "yTickLabel";
            yTickLabel.Size = new Size(20, 20);
            yTickLabel.TabIndex = 9;
            yTickLabel.Text = "Y:";
            // 
            // xTickLabel
            // 
            xTickLabel.AutoSize = true;
            xTickLabel.Font = new Font("Segoe UI", 11F);
            xTickLabel.Location = new Point(14, 99);
            xTickLabel.Name = "xTickLabel";
            xTickLabel.Size = new Size(21, 20);
            xTickLabel.TabIndex = 8;
            xTickLabel.Text = "X:";
            // 
            // xyStepLabel
            // 
            xyStepLabel.AutoSize = true;
            xyStepLabel.Font = new Font("Segoe UI", 11F);
            xyStepLabel.Location = new Point(14, 79);
            xyStepLabel.Name = "xyStepLabel";
            xyStepLabel.Size = new Size(70, 20);
            xyStepLabel.TabIndex = 7;
            xyStepLabel.Text = "X, Y Step:";
            // 
            // setGraphConfigBtn
            // 
            setGraphConfigBtn.Cursor = Cursors.Hand;
            setGraphConfigBtn.Location = new Point(37, 128);
            setGraphConfigBtn.Name = "setGraphConfigBtn";
            setGraphConfigBtn.Size = new Size(175, 48);
            setGraphConfigBtn.TabIndex = 6;
            setGraphConfigBtn.Text = "Set";
            setGraphConfigBtn.UseVisualStyleBackColor = true;
            setGraphConfigBtn.Click += SetGraphConfig;
            // 
            // yRangeTopInput
            // 
            yRangeTopInput.Location = new Point(134, 53);
            yRangeTopInput.Name = "yRangeTopInput";
            yRangeTopInput.Size = new Size(78, 23);
            yRangeTopInput.TabIndex = 5;
            yRangeTopInput.Text = "10";
            // 
            // yRangeBottomInput
            // 
            yRangeBottomInput.Location = new Point(37, 53);
            yRangeBottomInput.Name = "yRangeBottomInput";
            yRangeBottomInput.Size = new Size(78, 23);
            yRangeBottomInput.TabIndex = 4;
            yRangeBottomInput.Text = "-10";
            // 
            // yGraphRangeLabel
            // 
            yGraphRangeLabel.AutoSize = true;
            yGraphRangeLabel.Font = new Font("Segoe UI", 11F);
            yGraphRangeLabel.Location = new Point(14, 53);
            yGraphRangeLabel.Name = "yGraphRangeLabel";
            yGraphRangeLabel.Size = new Size(122, 20);
            yGraphRangeLabel.TabIndex = 3;
            yGraphRangeLabel.Text = "Y:                      to\r\n";
            // 
            // xRangeRightInput
            // 
            xRangeRightInput.Location = new Point(134, 24);
            xRangeRightInput.Name = "xRangeRightInput";
            xRangeRightInput.Size = new Size(78, 23);
            xRangeRightInput.TabIndex = 2;
            xRangeRightInput.Text = "10";
            // 
            // xRangeLeftInput
            // 
            xRangeLeftInput.Location = new Point(37, 24);
            xRangeLeftInput.Name = "xRangeLeftInput";
            xRangeLeftInput.Size = new Size(78, 23);
            xRangeLeftInput.TabIndex = 1;
            xRangeLeftInput.Text = "-10";
            // 
            // xGraphRangeLabel
            // 
            xGraphRangeLabel.AutoSize = true;
            xGraphRangeLabel.Font = new Font("Segoe UI", 11F);
            xGraphRangeLabel.Location = new Point(14, 24);
            xGraphRangeLabel.Name = "xGraphRangeLabel";
            xGraphRangeLabel.Size = new Size(123, 20);
            xGraphRangeLabel.TabIndex = 0;
            xGraphRangeLabel.Text = "X:                      to\r\n";
            // 
            // functionInputsList
            // 
            functionInputsList.FormattingEnabled = true;
            functionInputsList.Location = new Point(12, 27);
            functionInputsList.Name = "functionInputsList";
            functionInputsList.Size = new Size(505, 289);
            functionInputsList.TabIndex = 2;
            functionInputsList.SelectedIndexChanged += GraphSelectedFunction;
            // 
            // pairsTable
            // 
            pairsTable.AllowUserToAddRows = false;
            pairsTable.AllowUserToDeleteRows = false;
            pairsTable.AllowUserToResizeColumns = false;
            pairsTable.AllowUserToResizeRows = false;
            pairsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pairsTable.Columns.AddRange(new DataGridViewColumn[] { Input, Output });
            pairsTable.Location = new Point(523, 27);
            pairsTable.Name = "pairsTable";
            pairsTable.RowHeadersVisible = false;
            pairsTable.Size = new Size(203, 250);
            pairsTable.TabIndex = 3;
            // 
            // Input
            // 
            Input.HeaderText = "x";
            Input.Name = "Input";
            // 
            // Output
            // 
            Output.HeaderText = "y / f(x)";
            Output.Name = "Output";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, insertToolStripMenuItem, graphToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1344, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openGraphToolStripMenuItem, closeToolStripMenuItem, clearGraphsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openGraphToolStripMenuItem
            // 
            openGraphToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { projectToolStripMenuItem, graphToolStripMenuItem1, datasetToolStripMenuItem });
            openGraphToolStripMenuItem.Name = "openGraphToolStripMenuItem";
            openGraphToolStripMenuItem.Size = new Size(149, 22);
            openGraphToolStripMenuItem.Text = "Open";
            // 
            // projectToolStripMenuItem
            // 
            projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            projectToolStripMenuItem.Size = new Size(113, 22);
            projectToolStripMenuItem.Text = "Project";
            // 
            // graphToolStripMenuItem1
            // 
            graphToolStripMenuItem1.Name = "graphToolStripMenuItem1";
            graphToolStripMenuItem1.Size = new Size(113, 22);
            graphToolStripMenuItem1.Text = "Graph";
            // 
            // datasetToolStripMenuItem
            // 
            datasetToolStripMenuItem.Name = "datasetToolStripMenuItem";
            datasetToolStripMenuItem.Size = new Size(113, 22);
            datasetToolStripMenuItem.Text = "Dataset";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(149, 22);
            closeToolStripMenuItem.Text = "Close";
            // 
            // clearGraphsToolStripMenuItem
            // 
            clearGraphsToolStripMenuItem.Name = "clearGraphsToolStripMenuItem";
            clearGraphsToolStripMenuItem.Size = new Size(149, 22);
            clearGraphsToolStripMenuItem.Text = "Clear Graph(s)";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // insertToolStripMenuItem
            // 
            insertToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem });
            insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            insertToolStripMenuItem.Size = new Size(48, 20);
            insertToolStripMenuItem.Text = "Insert";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { functionToolStripMenuItem, constraintToolStripMenuItem });
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(98, 22);
            newToolStripMenuItem.Text = "New";
            // 
            // functionToolStripMenuItem
            // 
            functionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createFunctionToolStripMenuItem, trigonometricToolStripMenuItem, logarithmicToolStripMenuItem, exponentialToolStripMenuItem });
            functionToolStripMenuItem.Name = "functionToolStripMenuItem";
            functionToolStripMenuItem.Size = new Size(129, 22);
            functionToolStripMenuItem.Text = "Function";
            // 
            // createFunctionToolStripMenuItem
            // 
            createFunctionToolStripMenuItem.Name = "createFunctionToolStripMenuItem";
            createFunctionToolStripMenuItem.Size = new Size(158, 22);
            createFunctionToolStripMenuItem.Text = "Create Function";
            // 
            // trigonometricToolStripMenuItem
            // 
            trigonometricToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sinToolStripMenuItem, cosToolStripMenuItem, tanToolStripMenuItem, secToolStripMenuItem, cscToolStripMenuItem, cotToolStripMenuItem, sinhToolStripMenuItem, coshToolStripMenuItem, tanhToolStripMenuItem, cscToolStripMenuItem1, cschToolStripMenuItem, cothToolStripMenuItem, sincToolStripMenuItem });
            trigonometricToolStripMenuItem.Name = "trigonometricToolStripMenuItem";
            trigonometricToolStripMenuItem.Size = new Size(158, 22);
            trigonometricToolStripMenuItem.Text = "Trigonometric";
            // 
            // sinToolStripMenuItem
            // 
            sinToolStripMenuItem.Name = "sinToolStripMenuItem";
            sinToolStripMenuItem.Size = new Size(101, 22);
            sinToolStripMenuItem.Text = "Sin";
            // 
            // cosToolStripMenuItem
            // 
            cosToolStripMenuItem.Name = "cosToolStripMenuItem";
            cosToolStripMenuItem.Size = new Size(101, 22);
            cosToolStripMenuItem.Text = "Cos";
            // 
            // tanToolStripMenuItem
            // 
            tanToolStripMenuItem.Name = "tanToolStripMenuItem";
            tanToolStripMenuItem.Size = new Size(101, 22);
            tanToolStripMenuItem.Text = "Tan";
            // 
            // secToolStripMenuItem
            // 
            secToolStripMenuItem.Name = "secToolStripMenuItem";
            secToolStripMenuItem.Size = new Size(101, 22);
            secToolStripMenuItem.Text = "Sec";
            // 
            // cscToolStripMenuItem
            // 
            cscToolStripMenuItem.Name = "cscToolStripMenuItem";
            cscToolStripMenuItem.Size = new Size(101, 22);
            cscToolStripMenuItem.Text = "Csc";
            // 
            // cotToolStripMenuItem
            // 
            cotToolStripMenuItem.Name = "cotToolStripMenuItem";
            cotToolStripMenuItem.Size = new Size(101, 22);
            cotToolStripMenuItem.Text = "Cot";
            // 
            // sinhToolStripMenuItem
            // 
            sinhToolStripMenuItem.Name = "sinhToolStripMenuItem";
            sinhToolStripMenuItem.Size = new Size(101, 22);
            sinhToolStripMenuItem.Text = "Sinh";
            // 
            // coshToolStripMenuItem
            // 
            coshToolStripMenuItem.Name = "coshToolStripMenuItem";
            coshToolStripMenuItem.Size = new Size(101, 22);
            coshToolStripMenuItem.Text = "Cosh";
            // 
            // tanhToolStripMenuItem
            // 
            tanhToolStripMenuItem.Name = "tanhToolStripMenuItem";
            tanhToolStripMenuItem.Size = new Size(101, 22);
            tanhToolStripMenuItem.Text = "Tanh";
            // 
            // cscToolStripMenuItem1
            // 
            cscToolStripMenuItem1.Name = "cscToolStripMenuItem1";
            cscToolStripMenuItem1.Size = new Size(101, 22);
            cscToolStripMenuItem1.Text = "Sech";
            // 
            // cschToolStripMenuItem
            // 
            cschToolStripMenuItem.Name = "cschToolStripMenuItem";
            cschToolStripMenuItem.Size = new Size(101, 22);
            cschToolStripMenuItem.Text = "Csch";
            // 
            // cothToolStripMenuItem
            // 
            cothToolStripMenuItem.Name = "cothToolStripMenuItem";
            cothToolStripMenuItem.Size = new Size(101, 22);
            cothToolStripMenuItem.Text = "Coth";
            // 
            // sincToolStripMenuItem
            // 
            sincToolStripMenuItem.Name = "sincToolStripMenuItem";
            sincToolStripMenuItem.Size = new Size(101, 22);
            sincToolStripMenuItem.Text = "Sinc";
            // 
            // logarithmicToolStripMenuItem
            // 
            logarithmicToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { log10ToolStripMenuItem, logbToolStripMenuItem, lnToolStripMenuItem });
            logarithmicToolStripMenuItem.Name = "logarithmicToolStripMenuItem";
            logarithmicToolStripMenuItem.Size = new Size(158, 22);
            logarithmicToolStripMenuItem.Text = "Logarithmic";
            // 
            // log10ToolStripMenuItem
            // 
            log10ToolStripMenuItem.Name = "log10ToolStripMenuItem";
            log10ToolStripMenuItem.Size = new Size(106, 22);
            log10ToolStripMenuItem.Text = "Log10";
            // 
            // logbToolStripMenuItem
            // 
            logbToolStripMenuItem.Name = "logbToolStripMenuItem";
            logbToolStripMenuItem.Size = new Size(106, 22);
            logbToolStripMenuItem.Text = "Logb";
            // 
            // lnToolStripMenuItem
            // 
            lnToolStripMenuItem.Name = "lnToolStripMenuItem";
            lnToolStripMenuItem.Size = new Size(106, 22);
            lnToolStripMenuItem.Text = "Ln";
            // 
            // exponentialToolStripMenuItem
            // 
            exponentialToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, eˣToolStripMenuItem, bˣToolStripMenuItem });
            exponentialToolStripMenuItem.Name = "exponentialToolStripMenuItem";
            exponentialToolStripMenuItem.Size = new Size(158, 22);
            exponentialToolStripMenuItem.Text = "Exponential";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(89, 22);
            toolStripMenuItem2.Text = "10ˣ";
            // 
            // eˣToolStripMenuItem
            // 
            eˣToolStripMenuItem.Name = "eˣToolStripMenuItem";
            eˣToolStripMenuItem.Size = new Size(89, 22);
            eˣToolStripMenuItem.Text = "eˣ";
            // 
            // bˣToolStripMenuItem
            // 
            bˣToolStripMenuItem.Name = "bˣToolStripMenuItem";
            bˣToolStripMenuItem.Size = new Size(89, 22);
            bˣToolStripMenuItem.Text = "bˣ";
            // 
            // constraintToolStripMenuItem
            // 
            constraintToolStripMenuItem.Name = "constraintToolStripMenuItem";
            constraintToolStripMenuItem.Size = new Size(129, 22);
            constraintToolStripMenuItem.Text = "Constraint";
            // 
            // graphToolStripMenuItem
            // 
            graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            graphToolStripMenuItem.Size = new Size(51, 20);
            graphToolStripMenuItem.Text = "Graph";
            // 
            // functionInput
            // 
            functionInput.Font = new Font("Segoe UI", 11F);
            functionInput.Location = new Point(12, 346);
            functionInput.Name = "functionInput";
            functionInput.Size = new Size(505, 27);
            functionInput.TabIndex = 5;
            // 
            // insertFunctionBtn
            // 
            insertFunctionBtn.Cursor = Cursors.Hand;
            insertFunctionBtn.Location = new Point(523, 346);
            insertFunctionBtn.Name = "insertFunctionBtn";
            insertFunctionBtn.Size = new Size(95, 27);
            insertFunctionBtn.TabIndex = 6;
            insertFunctionBtn.Text = "Add f(x)";
            insertFunctionBtn.UseVisualStyleBackColor = true;
            insertFunctionBtn.Click += InsertFunction;
            // 
            // clearGraphsBtn
            // 
            clearGraphsBtn.Cursor = Cursors.Hand;
            clearGraphsBtn.Location = new Point(631, 347);
            clearGraphsBtn.Name = "clearGraphsBtn";
            clearGraphsBtn.Size = new Size(95, 27);
            clearGraphsBtn.TabIndex = 7;
            clearGraphsBtn.Text = "Clear All";
            clearGraphsBtn.UseVisualStyleBackColor = true;
            clearGraphsBtn.Click += ClearAll;
            // 
            // funcLabel
            // 
            funcLabel.AutoSize = true;
            funcLabel.Location = new Point(12, 321);
            funcLabel.Name = "funcLabel";
            funcLabel.Size = new Size(369, 15);
            funcLabel.TabIndex = 8;
            funcLabel.Text = "Function f(x)        Note: Functions should be in 'y =' or 'f(x) =' format.";
            // 
            // computeFunctionalValBtn
            // 
            computeFunctionalValBtn.Cursor = Cursors.Hand;
            computeFunctionalValBtn.Location = new Point(631, 283);
            computeFunctionalValBtn.Name = "computeFunctionalValBtn";
            computeFunctionalValBtn.Size = new Size(95, 27);
            computeFunctionalValBtn.TabIndex = 9;
            computeFunctionalValBtn.Text = "Calculate";
            computeFunctionalValBtn.UseVisualStyleBackColor = true;
            computeFunctionalValBtn.Click += ComputeValueFunction;
            // 
            // functionValueInput
            // 
            functionValueInput.Location = new Point(523, 286);
            functionValueInput.Name = "functionValueInput";
            functionValueInput.Size = new Size(95, 23);
            functionValueInput.TabIndex = 10;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(523, 314);
            button1.Name = "button1";
            button1.Size = new Size(95, 27);
            button1.TabIndex = 11;
            button1.Text = "Remove f(x)";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(631, 315);
            button2.Name = "button2";
            button2.Size = new Size(95, 27);
            button2.TabIndex = 12;
            button2.Text = "Clear Graph";
            button2.UseVisualStyleBackColor = true;
            // 
            // outputLogConsole
            // 
            outputLogConsole.BorderStyle = BorderStyle.None;
            outputLogConsole.Location = new Point(6, 22);
            outputLogConsole.Name = "outputLogConsole";
            outputLogConsole.Size = new Size(600, 152);
            outputLogConsole.TabIndex = 13;
            outputLogConsole.Text = "";
            // 
            // outputDebugGroupBox
            // 
            outputDebugGroupBox.Controls.Add(reportBugBtn);
            outputDebugGroupBox.Controls.Add(clearConsoleBtn);
            outputDebugGroupBox.Controls.Add(outputLogConsole);
            outputDebugGroupBox.Location = new Point(12, 640);
            outputDebugGroupBox.Name = "outputDebugGroupBox";
            outputDebugGroupBox.Size = new Size(714, 182);
            outputDebugGroupBox.TabIndex = 14;
            outputDebugGroupBox.TabStop = false;
            outputDebugGroupBox.Text = "Output Console";
            // 
            // reportBugBtn
            // 
            reportBugBtn.Cursor = Cursors.Hand;
            reportBugBtn.Location = new Point(613, 57);
            reportBugBtn.Name = "reportBugBtn";
            reportBugBtn.Size = new Size(95, 27);
            reportBugBtn.TabIndex = 16;
            reportBugBtn.Text = "Report Bug";
            reportBugBtn.UseVisualStyleBackColor = true;
            // 
            // clearConsoleBtn
            // 
            clearConsoleBtn.Cursor = Cursors.Hand;
            clearConsoleBtn.Location = new Point(613, 24);
            clearConsoleBtn.Name = "clearConsoleBtn";
            clearConsoleBtn.Size = new Size(95, 27);
            clearConsoleBtn.TabIndex = 15;
            clearConsoleBtn.Text = "Clear";
            clearConsoleBtn.UseVisualStyleBackColor = true;
            // 
            // GraphChartingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 834);
            Controls.Add(outputDebugGroupBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(functionValueInput);
            Controls.Add(computeFunctionalValBtn);
            Controls.Add(funcLabel);
            Controls.Add(clearGraphsBtn);
            Controls.Add(insertFunctionBtn);
            Controls.Add(functionInput);
            Controls.Add(pairsTable);
            Controls.Add(functionInputsList);
            Controls.Add(graphSettingsGroupBox);
            Controls.Add(plotGraph);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "GraphChartingForm";
            Text = "Graphing & Charting";
            graphSettingsGroupBox.ResumeLayout(false);
            graphSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pairsTable).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            outputDebugGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot plotGraph;
        private GroupBox graphSettingsGroupBox;
        private Button setGraphConfigBtn;
        private TextBox yRangeTopInput;
        private TextBox yRangeBottomInput;
        private Label yGraphRangeLabel;
        private TextBox xRangeRightInput;
        private TextBox xRangeLeftInput;
        private Label xGraphRangeLabel;
        private TextBox yTickInput;
        private TextBox xTickInput;
        private Label yTickLabel;
        private Label xTickLabel;
        private Label xyStepLabel;
        private ListBox functionInputsList;
        private DataGridView pairsTable;
        private DataGridViewTextBoxColumn Input;
        private DataGridViewTextBoxColumn Output;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem insertToolStripMenuItem;
        private ToolStripMenuItem graphToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem functionToolStripMenuItem;
        private ToolStripMenuItem constraintToolStripMenuItem;
        private ToolStripMenuItem openGraphToolStripMenuItem;
        private ToolStripMenuItem projectToolStripMenuItem;
        private ToolStripMenuItem graphToolStripMenuItem1;
        private ToolStripMenuItem datasetToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem clearGraphsToolStripMenuItem;
        private ToolStripMenuItem createFunctionToolStripMenuItem;
        private ToolStripMenuItem trigonometricToolStripMenuItem;
        private ToolStripMenuItem sinToolStripMenuItem;
        private ToolStripMenuItem cosToolStripMenuItem;
        private ToolStripMenuItem tanToolStripMenuItem;
        private ToolStripMenuItem secToolStripMenuItem;
        private ToolStripMenuItem cscToolStripMenuItem;
        private ToolStripMenuItem cotToolStripMenuItem;
        private ToolStripMenuItem sinhToolStripMenuItem;
        private ToolStripMenuItem coshToolStripMenuItem;
        private ToolStripMenuItem tanhToolStripMenuItem;
        private ToolStripMenuItem cscToolStripMenuItem1;
        private ToolStripMenuItem cschToolStripMenuItem;
        private ToolStripMenuItem cothToolStripMenuItem;
        private ToolStripMenuItem sincToolStripMenuItem;
        private ToolStripMenuItem logarithmicToolStripMenuItem;
        private ToolStripMenuItem log10ToolStripMenuItem;
        private ToolStripMenuItem logbToolStripMenuItem;
        private ToolStripMenuItem lnToolStripMenuItem;
        private ToolStripMenuItem exponentialToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem eˣToolStripMenuItem;
        private ToolStripMenuItem bˣToolStripMenuItem;
        private TextBox functionInput;
        private Button insertFunctionBtn;
        private Button clearGraphsBtn;
        private Label funcLabel;
        private Button computeFunctionalValBtn;
        private TextBox functionValueInput;
        private Button button1;
        private Button button2;
        private RichTextBox outputLogConsole;
        private GroupBox outputDebugGroupBox;
        private Button reportBugBtn;
        private Button clearConsoleBtn;
    }
}