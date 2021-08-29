namespace TSP_Code_Starter
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.crossOverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderCrossoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pMXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mutationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleMutationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displacementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tournamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roulletteWheelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMutationRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxLayout = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtPop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCities = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbOn = new System.Windows.Forms.RadioButton();
            this.rdbOff = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGeneration = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtElitismAmount = new System.Windows.Forms.TextBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblWarning2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crossOverToolStripMenuItem,
            this.mutationToolStripMenuItem,
            this.selectionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // crossOverToolStripMenuItem
            // 
            this.crossOverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderCrossoverToolStripMenuItem,
            this.simpleToolStripMenuItem,
            this.pMXToolStripMenuItem});
            this.crossOverToolStripMenuItem.Name = "crossOverToolStripMenuItem";
            this.crossOverToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.crossOverToolStripMenuItem.Text = "CrossOver";
            // 
            // orderCrossoverToolStripMenuItem
            // 
            this.orderCrossoverToolStripMenuItem.Name = "orderCrossoverToolStripMenuItem";
            this.orderCrossoverToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.orderCrossoverToolStripMenuItem.Text = "Order Crossover";
            this.orderCrossoverToolStripMenuItem.Click += new System.EventHandler(this.pMXToolStripMenuItem_Click);
            // 
            // simpleToolStripMenuItem
            // 
            this.simpleToolStripMenuItem.Name = "simpleToolStripMenuItem";
            this.simpleToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.simpleToolStripMenuItem.Text = "Simple Crossover";
            this.simpleToolStripMenuItem.Click += new System.EventHandler(this.simpleToolStripMenuItem_Click);
            // 
            // pMXToolStripMenuItem
            // 
            this.pMXToolStripMenuItem.Name = "pMXToolStripMenuItem";
            this.pMXToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.pMXToolStripMenuItem.Text = "PMX Crossover";
            this.pMXToolStripMenuItem.Click += new System.EventHandler(this.orderCrossoverToolStripMenuItem_Click);
            // 
            // mutationToolStripMenuItem
            // 
            this.mutationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleMutationToolStripMenuItem,
            this.inversionToolStripMenuItem,
            this.displacementToolStripMenuItem,
            this.reverseToolStripMenuItem});
            this.mutationToolStripMenuItem.Name = "mutationToolStripMenuItem";
            this.mutationToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.mutationToolStripMenuItem.Text = "Mutation";
            // 
            // simpleMutationToolStripMenuItem
            // 
            this.simpleMutationToolStripMenuItem.Name = "simpleMutationToolStripMenuItem";
            this.simpleMutationToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.simpleMutationToolStripMenuItem.Text = "Simple Mutation";
            this.simpleMutationToolStripMenuItem.Click += new System.EventHandler(this.simpleMutationToolStripMenuItem_Click);
            // 
            // inversionToolStripMenuItem
            // 
            this.inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            this.inversionToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.inversionToolStripMenuItem.Text = "Inversion";
            this.inversionToolStripMenuItem.Click += new System.EventHandler(this.inversionToolStripMenuItem_Click);
            // 
            // displacementToolStripMenuItem
            // 
            this.displacementToolStripMenuItem.Name = "displacementToolStripMenuItem";
            this.displacementToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.displacementToolStripMenuItem.Text = "Displacement";
            this.displacementToolStripMenuItem.Click += new System.EventHandler(this.displacementToolStripMenuItem_Click);
            // 
            // reverseToolStripMenuItem
            // 
            this.reverseToolStripMenuItem.Name = "reverseToolStripMenuItem";
            this.reverseToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.reverseToolStripMenuItem.Text = "Reverse";
            this.reverseToolStripMenuItem.Click += new System.EventHandler(this.reverseToolStripMenuItem_Click);
            // 
            // selectionToolStripMenuItem
            // 
            this.selectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tournamentToolStripMenuItem,
            this.roulletteWheelToolStripMenuItem,
            this.rankToolStripMenuItem});
            this.selectionToolStripMenuItem.Name = "selectionToolStripMenuItem";
            this.selectionToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.selectionToolStripMenuItem.Text = "Selection";
            // 
            // tournamentToolStripMenuItem
            // 
            this.tournamentToolStripMenuItem.Name = "tournamentToolStripMenuItem";
            this.tournamentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tournamentToolStripMenuItem.Text = "Tournament";
            this.tournamentToolStripMenuItem.Click += new System.EventHandler(this.roulletteWheelToolStripMenuItem_Click);
            // 
            // roulletteWheelToolStripMenuItem
            // 
            this.roulletteWheelToolStripMenuItem.Name = "roulletteWheelToolStripMenuItem";
            this.roulletteWheelToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.roulletteWheelToolStripMenuItem.Text = "RoulletteWheel";
            this.roulletteWheelToolStripMenuItem.Click += new System.EventHandler(this.tournamentToolStripMenuItem_Click);
            // 
            // rankToolStripMenuItem
            // 
            this.rankToolStripMenuItem.Name = "rankToolStripMenuItem";
            this.rankToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rankToolStripMenuItem.Text = "Rank";
            this.rankToolStripMenuItem.Click += new System.EventHandler(this.rankToolStripMenuItem_Click);
            // 
            // txtMutationRate
            // 
            this.txtMutationRate.Location = new System.Drawing.Point(132, 104);
            this.txtMutationRate.Name = "txtMutationRate";
            this.txtMutationRate.Size = new System.Drawing.Size(37, 20);
            this.txtMutationRate.TabIndex = 19;
            this.txtMutationRate.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mutation Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Layout";
            // 
            // cbxLayout
            // 
            this.cbxLayout.FormattingEnabled = true;
            this.cbxLayout.Items.AddRange(new object[] {
            "Circle",
            "Random"});
            this.cbxLayout.Location = new System.Drawing.Point(104, 157);
            this.cbxLayout.Name = "cbxLayout";
            this.cbxLayout.Size = new System.Drawing.Size(121, 21);
            this.cbxLayout.TabIndex = 16;
            this.cbxLayout.Text = "Circle";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(101, 237);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(121, 45);
            this.btnGenerate.TabIndex = 15;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtPop
            // 
            this.txtPop.Location = new System.Drawing.Point(132, 77);
            this.txtPop.Name = "txtPop";
            this.txtPop.Size = new System.Drawing.Size(37, 20);
            this.txtPop.TabIndex = 14;
            this.txtPop.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Population Size";
            // 
            // txtCities
            // 
            this.txtCities.Location = new System.Drawing.Point(132, 48);
            this.txtCities.Name = "txtCities";
            this.txtCities.Size = new System.Drawing.Size(37, 20);
            this.txtCities.TabIndex = 12;
            this.txtCities.Text = "20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Number Of Cities";
            // 
            // rdbOn
            // 
            this.rdbOn.AutoSize = true;
            this.rdbOn.Checked = true;
            this.rdbOn.Location = new System.Drawing.Point(104, 184);
            this.rdbOn.Name = "rdbOn";
            this.rdbOn.Size = new System.Drawing.Size(39, 17);
            this.rdbOn.TabIndex = 20;
            this.rdbOn.TabStop = true;
            this.rdbOn.Text = "On";
            this.rdbOn.UseVisualStyleBackColor = true;
            // 
            // rdbOff
            // 
            this.rdbOff.AutoSize = true;
            this.rdbOff.Location = new System.Drawing.Point(147, 183);
            this.rdbOff.Name = "rdbOff";
            this.rdbOff.Size = new System.Drawing.Size(39, 17);
            this.rdbOff.TabIndex = 21;
            this.rdbOff.TabStop = true;
            this.rdbOff.Text = "Off";
            this.rdbOff.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Elitism";
            // 
            // lbxOutput
            // 
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.Location = new System.Drawing.Point(12, 347);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.Size = new System.Drawing.Size(210, 641);
            this.lbxOutput.TabIndex = 23;
            // 
            // txtGen
            // 
            this.txtGen.Location = new System.Drawing.Point(132, 129);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(37, 20);
            this.txtGen.TabIndex = 25;
            this.txtGen.Text = "5000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Number of Generations";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Number of generations";
            // 
            // lblGeneration
            // 
            this.lblGeneration.AutoSize = true;
            this.lblGeneration.Location = new System.Drawing.Point(144, 300);
            this.lblGeneration.Name = "lblGeneration";
            this.lblGeneration.Size = new System.Drawing.Size(0, 13);
            this.lblGeneration.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Output of route distances";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Elitism Amount";
            // 
            // txtElitismAmount
            // 
            this.txtElitismAmount.Location = new System.Drawing.Point(132, 211);
            this.txtElitismAmount.Name = "txtElitismAmount";
            this.txtElitismAmount.Size = new System.Drawing.Size(37, 20);
            this.txtElitismAmount.TabIndex = 30;
            this.txtElitismAmount.Text = "5";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(186, 31);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 13);
            this.lblWarning.TabIndex = 31;
            // 
            // lblWarning2
            // 
            this.lblWarning2.AutoSize = true;
            this.lblWarning2.ForeColor = System.Drawing.Color.Red;
            this.lblWarning2.Location = new System.Drawing.Point(186, 58);
            this.lblWarning2.Name = "lblWarning2";
            this.lblWarning2.Size = new System.Drawing.Size(0, 13);
            this.lblWarning2.TabIndex = 32;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 1000);
            this.Controls.Add(this.lblWarning2);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.txtElitismAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblGeneration);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbxOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdbOff);
            this.Controls.Add(this.rdbOn);
            this.Controls.Add(this.txtMutationRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxLayout);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtPop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCities);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crossOverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderCrossoverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mutationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleMutationToolStripMenuItem;
        private System.Windows.Forms.TextBox txtMutationRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxLayout;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtPop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem selectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tournamentToolStripMenuItem;
        private System.Windows.Forms.RadioButton rdbOn;
        private System.Windows.Forms.RadioButton rdbOff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbxOutput;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGeneration;
        private System.Windows.Forms.ToolStripMenuItem simpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pMXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roulletteWheelToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtElitismAmount;
        private System.Windows.Forms.ToolStripMenuItem displacementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reverseToolStripMenuItem;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.ToolStripMenuItem rankToolStripMenuItem;
        private System.Windows.Forms.Label lblWarning2;

    }
}

