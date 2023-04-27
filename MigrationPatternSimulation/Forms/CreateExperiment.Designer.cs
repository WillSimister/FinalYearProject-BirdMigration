namespace MigrationPatternSimulation.Forms
{
    partial class CreateExperiment
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ExperimentName = new System.Windows.Forms.TextBox();
            this.comboBox_SelectAgent = new System.Windows.Forms.ComboBox();
            this.comboBox_SelectExperiment = new System.Windows.Forms.ComboBox();
            this.button_Create = new System.Windows.Forms.Button();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Experiment Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Agent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select Environment";
            // 
            // textBox_ExperimentName
            // 
            this.textBox_ExperimentName.Location = new System.Drawing.Point(12, 32);
            this.textBox_ExperimentName.Name = "textBox_ExperimentName";
            this.textBox_ExperimentName.Size = new System.Drawing.Size(268, 27);
            this.textBox_ExperimentName.TabIndex = 3;
            // 
            // comboBox_SelectAgent
            // 
            this.comboBox_SelectAgent.FormattingEnabled = true;
            this.comboBox_SelectAgent.Location = new System.Drawing.Point(12, 138);
            this.comboBox_SelectAgent.Name = "comboBox_SelectAgent";
            this.comboBox_SelectAgent.Size = new System.Drawing.Size(268, 28);
            this.comboBox_SelectAgent.TabIndex = 4;
            this.comboBox_SelectAgent.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectAgent_SelectedIndexChanged);
            // 
            // comboBox_SelectExperiment
            // 
            this.comboBox_SelectExperiment.FormattingEnabled = true;
            this.comboBox_SelectExperiment.Location = new System.Drawing.Point(12, 192);
            this.comboBox_SelectExperiment.Name = "comboBox_SelectExperiment";
            this.comboBox_SelectExperiment.Size = new System.Drawing.Size(268, 28);
            this.comboBox_SelectExperiment.TabIndex = 5;
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(12, 230);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(94, 29);
            this.button_Create.TabIndex = 6;
            this.button_Create.Text = "Create...";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(12, 85);
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(268, 27);
            this.textBox_Description.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Experiment Description";
            // 
            // CreateExperiment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 307);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.comboBox_SelectExperiment);
            this.Controls.Add(this.comboBox_SelectAgent);
            this.Controls.Add(this.textBox_ExperimentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateExperiment";
            this.Text = "Create Experiment";
            this.Load += new System.EventHandler(this.CreateExperiment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_ExperimentName;
        private ComboBox comboBox_SelectAgent;
        private ComboBox comboBox_SelectExperiment;
        private Button button_Create;
        private TextBox textBox_Description;
        private Label label4;
    }
}