namespace MigrationPatternSimulation.Forms
{
    partial class AddRuleToAgentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_AgentName = new System.Windows.Forms.Label();
            this.comboBox_SimProp = new System.Windows.Forms.ComboBox();
            this.simProp_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Comparator = new System.Windows.Forms.ComboBox();
            this.label_Comparator = new System.Windows.Forms.Label();
            this.label_value = new System.Windows.Forms.Label();
            this.label_Decision = new System.Windows.Forms.Label();
            this.comboBox_Decision = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_CreateRule = new System.Windows.Forms.Button();
            this.numericUpDown_Value = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_RuleName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Value)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "RULE: ";
            // 
            // label_AgentName
            // 
            this.label_AgentName.AutoSize = true;
            this.label_AgentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_AgentName.Location = new System.Drawing.Point(3, 0);
            this.label_AgentName.Name = "label_AgentName";
            this.label_AgentName.Size = new System.Drawing.Size(838, 27);
            this.label_AgentName.TabIndex = 1;
            this.label_AgentName.Text = "agentName";
            this.label_AgentName.Click += new System.EventHandler(this.label_AgentName_Click);
            // 
            // comboBox_SimProp
            // 
            this.comboBox_SimProp.FormattingEnabled = true;
            this.comboBox_SimProp.Location = new System.Drawing.Point(61, 55);
            this.comboBox_SimProp.Name = "comboBox_SimProp";
            this.comboBox_SimProp.Size = new System.Drawing.Size(175, 28);
            this.comboBox_SimProp.TabIndex = 2;
            this.comboBox_SimProp.Text = "Simulation Property...";
            this.comboBox_SimProp.SelectedIndexChanged += new System.EventHandler(this.comboBox_SimProp_SelectedIndexChanged);
            // 
            // simProp_label
            // 
            this.simProp_label.AutoSize = true;
            this.simProp_label.Location = new System.Drawing.Point(61, 32);
            this.simProp_label.Name = "simProp_label";
            this.simProp_label.Size = new System.Drawing.Size(140, 20);
            this.simProp_label.TabIndex = 3;
            this.simProp_label.Text = "Simulation Property";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "IF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "IS";
            // 
            // comboBox_Comparator
            // 
            this.comboBox_Comparator.FormattingEnabled = true;
            this.comboBox_Comparator.Location = new System.Drawing.Point(266, 55);
            this.comboBox_Comparator.Name = "comboBox_Comparator";
            this.comboBox_Comparator.Size = new System.Drawing.Size(175, 28);
            this.comboBox_Comparator.TabIndex = 6;
            this.comboBox_Comparator.Text = "Comparator...";
            this.comboBox_Comparator.SelectedIndexChanged += new System.EventHandler(this.comboBox_Comparator_SelectedIndexChanged);
            // 
            // label_Comparator
            // 
            this.label_Comparator.AutoSize = true;
            this.label_Comparator.Location = new System.Drawing.Point(266, 32);
            this.label_Comparator.Name = "label_Comparator";
            this.label_Comparator.Size = new System.Drawing.Size(89, 20);
            this.label_Comparator.TabIndex = 7;
            this.label_Comparator.Text = "Comparator";
            // 
            // label_value
            // 
            this.label_value.AutoSize = true;
            this.label_value.Location = new System.Drawing.Point(447, 32);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(45, 20);
            this.label_value.TabIndex = 8;
            this.label_value.Text = "Value";
            // 
            // label_Decision
            // 
            this.label_Decision.AutoSize = true;
            this.label_Decision.Location = new System.Drawing.Point(638, 32);
            this.label_Decision.Name = "label_Decision";
            this.label_Decision.Size = new System.Drawing.Size(66, 20);
            this.label_Decision.TabIndex = 12;
            this.label_Decision.Text = "Decision";
            // 
            // comboBox_Decision
            // 
            this.comboBox_Decision.FormattingEnabled = true;
            this.comboBox_Decision.Location = new System.Drawing.Point(638, 55);
            this.comboBox_Decision.Name = "comboBox_Decision";
            this.comboBox_Decision.Size = new System.Drawing.Size(175, 28);
            this.comboBox_Decision.TabIndex = 11;
            this.comboBox_Decision.Text = "Decision";
            this.comboBox_Decision.SelectedIndexChanged += new System.EventHandler(this.comboBox_Decision_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(596, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "THEN ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button_CreateRule
            // 
            this.button_CreateRule.Enabled = false;
            this.button_CreateRule.Location = new System.Drawing.Point(719, 89);
            this.button_CreateRule.Name = "button_CreateRule";
            this.button_CreateRule.Size = new System.Drawing.Size(94, 29);
            this.button_CreateRule.TabIndex = 13;
            this.button_CreateRule.Text = "Create Rule";
            this.button_CreateRule.UseVisualStyleBackColor = true;
            this.button_CreateRule.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown_Value
            // 
            this.numericUpDown_Value.Location = new System.Drawing.Point(447, 55);
            this.numericUpDown_Value.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_Value.Name = "numericUpDown_Value";
            this.numericUpDown_Value.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown_Value.TabIndex = 14;
            this.numericUpDown_Value.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown_Value);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_SimProp);
            this.groupBox1.Controls.Add(this.button_CreateRule);
            this.groupBox1.Controls.Add(this.simProp_label);
            this.groupBox1.Controls.Add(this.label_Decision);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_Decision);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox_Comparator);
            this.groupBox1.Controls.Add(this.label_value);
            this.groupBox1.Controls.Add(this.label_Comparator);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(838, 124);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rule Creation";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_AgentName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_RuleName, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(844, 184);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // textBox_RuleName
            // 
            this.textBox_RuleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_RuleName.Location = new System.Drawing.Point(3, 30);
            this.textBox_RuleName.Name = "textBox_RuleName";
            this.textBox_RuleName.PlaceholderText = "Rule Name...";
            this.textBox_RuleName.Size = new System.Drawing.Size(838, 27);
            this.textBox_RuleName.TabIndex = 17;
            // 
            // AddRuleToAgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 184);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddRuleToAgentForm";
            this.Text = "Add Rule";
            this.Load += new System.EventHandler(this.AddRuleToAgentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Value)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label_AgentName;
        private ComboBox comboBox_SimProp;
        private Label simProp_label;
        private Label label3;
        private Label label4;
        private ComboBox comboBox_Comparator;
        private Label label_Comparator;
        private Label label_value;
        private Label label_Decision;
        private ComboBox comboBox_Decision;
        private Label label6;
        private Button button_CreateRule;
        private NumericUpDown numericUpDown_Value;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox_RuleName;
    }
}