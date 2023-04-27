namespace MigrationPatternSimulation.Forms
{
    partial class CreateAgent_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_nestingMigrationMonth = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_BreedingMigrationMonth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button_CreateAgent = new System.Windows.Forms.Button();
            this.comboBox_JanuaryCountry = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_nestingCountry = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_BreedingCountry = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nestingMigrationMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BreedingMigrationMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown_nestingMigrationMonth);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDown_BreedingMigrationMonth);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button_CreateAgent);
            this.groupBox1.Controls.Add(this.comboBox_JanuaryCountry);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_nestingCountry);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_BreedingCountry);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 393);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New Agent";
            // 
            // numericUpDown_nestingMigrationMonth
            // 
            this.numericUpDown_nestingMigrationMonth.Location = new System.Drawing.Point(8, 266);
            this.numericUpDown_nestingMigrationMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown_nestingMigrationMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_nestingMigrationMonth.Name = "numericUpDown_nestingMigrationMonth";
            this.numericUpDown_nestingMigrationMonth.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown_nestingMigrationMonth.TabIndex = 12;
            this.numericUpDown_nestingMigrationMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Normal Nesting Migration Month";
            // 
            // numericUpDown_BreedingMigrationMonth
            // 
            this.numericUpDown_BreedingMigrationMonth.Location = new System.Drawing.Point(8, 156);
            this.numericUpDown_BreedingMigrationMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown_BreedingMigrationMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_BreedingMigrationMonth.Name = "numericUpDown_BreedingMigrationMonth";
            this.numericUpDown_BreedingMigrationMonth.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown_BreedingMigrationMonth.TabIndex = 10;
            this.numericUpDown_BreedingMigrationMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Normal Breeding Migration Month";
            // 
            // button_CreateAgent
            // 
            this.button_CreateAgent.Enabled = false;
            this.button_CreateAgent.Location = new System.Drawing.Point(4, 353);
            this.button_CreateAgent.Name = "button_CreateAgent";
            this.button_CreateAgent.Size = new System.Drawing.Size(94, 29);
            this.button_CreateAgent.TabIndex = 8;
            this.button_CreateAgent.Text = "Create";
            this.button_CreateAgent.UseVisualStyleBackColor = true;
            this.button_CreateAgent.Click += new System.EventHandler(this.buttonCreateAgent_Click);
            // 
            // comboBox_JanuaryCountry
            // 
            this.comboBox_JanuaryCountry.FormattingEnabled = true;
            this.comboBox_JanuaryCountry.Location = new System.Drawing.Point(4, 319);
            this.comboBox_JanuaryCountry.Name = "comboBox_JanuaryCountry";
            this.comboBox_JanuaryCountry.Size = new System.Drawing.Size(374, 28);
            this.comboBox_JanuaryCountry.TabIndex = 7;
            this.comboBox_JanuaryCountry.SelectedIndexChanged += new System.EventHandler(this.comboBox_JanuaryCountry_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Which country does this agent reside in January";
            // 
            // comboBox_nestingCountry
            // 
            this.comboBox_nestingCountry.FormattingEnabled = true;
            this.comboBox_nestingCountry.Location = new System.Drawing.Point(6, 212);
            this.comboBox_nestingCountry.Name = "comboBox_nestingCountry";
            this.comboBox_nestingCountry.Size = new System.Drawing.Size(374, 28);
            this.comboBox_nestingCountry.TabIndex = 5;
            this.comboBox_nestingCountry.SelectedIndexChanged += new System.EventHandler(this.comboBox_nestingCountry_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Normal Nesting Country";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox_BreedingCountry
            // 
            this.comboBox_BreedingCountry.FormattingEnabled = true;
            this.comboBox_BreedingCountry.Location = new System.Drawing.Point(8, 102);
            this.comboBox_BreedingCountry.Name = "comboBox_BreedingCountry";
            this.comboBox_BreedingCountry.Size = new System.Drawing.Size(374, 28);
            this.comboBox_BreedingCountry.TabIndex = 3;
            this.comboBox_BreedingCountry.SelectedIndexChanged += new System.EventHandler(this.comboBox_BreedingCountry_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Normal Breeding Country";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 27);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agent Name";
            // 
            // CreateAgent_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 394);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateAgent_Form";
            this.Text = "Create New Agent";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nestingMigrationMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BreedingMigrationMonth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button button_CreateAgent;
        private ComboBox comboBox_JanuaryCountry;
        private Label label4;
        private ComboBox comboBox_nestingCountry;
        private Label label3;
        private ComboBox comboBox_BreedingCountry;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private NumericUpDown numericUpDown_BreedingMigrationMonth;
        private Label label5;
        private NumericUpDown numericUpDown_nestingMigrationMonth;
        private Label label6;
    }
}