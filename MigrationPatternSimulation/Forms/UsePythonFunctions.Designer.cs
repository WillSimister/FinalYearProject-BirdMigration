namespace MigrationPatternSimulation.Forms
{
    partial class UsePythonFunctions
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
            this.button_CheckAccuracy = new System.Windows.Forms.Button();
            this.button_run = new System.Windows.Forms.Button();
            this.comboBox_Datasets = new System.Windows.Forms.ComboBox();
            this.comboBox_MLAlgorithms = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_CheckAccuracy
            // 
            this.button_CheckAccuracy.Enabled = false;
            this.button_CheckAccuracy.Location = new System.Drawing.Point(250, 54);
            this.button_CheckAccuracy.Name = "button_CheckAccuracy";
            this.button_CheckAccuracy.Size = new System.Drawing.Size(227, 29);
            this.button_CheckAccuracy.TabIndex = 3;
            this.button_CheckAccuracy.Text = "Check Algorithm Accuracies";
            this.button_CheckAccuracy.UseVisualStyleBackColor = true;
            this.button_CheckAccuracy.Click += new System.EventHandler(this.button_CheckAccuracy_Click);
            // 
            // button_run
            // 
            this.button_run.Enabled = false;
            this.button_run.Location = new System.Drawing.Point(17, 54);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(227, 29);
            this.button_run.TabIndex = 4;
            this.button_run.Text = "Run";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // comboBox_Datasets
            // 
            this.comboBox_Datasets.FormattingEnabled = true;
            this.comboBox_Datasets.Location = new System.Drawing.Point(9, 26);
            this.comboBox_Datasets.Name = "comboBox_Datasets";
            this.comboBox_Datasets.Size = new System.Drawing.Size(227, 28);
            this.comboBox_Datasets.TabIndex = 6;
            this.comboBox_Datasets.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Datasets_SelectionChangeCommitted);
            // 
            // comboBox_MLAlgorithms
            // 
            this.comboBox_MLAlgorithms.FormattingEnabled = true;
            this.comboBox_MLAlgorithms.Location = new System.Drawing.Point(17, 20);
            this.comboBox_MLAlgorithms.Name = "comboBox_MLAlgorithms";
            this.comboBox_MLAlgorithms.Size = new System.Drawing.Size(227, 28);
            this.comboBox_MLAlgorithms.TabIndex = 7;
            this.comboBox_MLAlgorithms.SelectionChangeCommitted += new System.EventHandler(this.comboBox_MLAlgorithms_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Datasets);
            this.groupBox1.Location = new System.Drawing.Point(3, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 65);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Dataset";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_run);
            this.groupBox2.Controls.Add(this.comboBox_MLAlgorithms);
            this.groupBox2.Controls.Add(this.button_CheckAccuracy);
            this.groupBox2.Location = new System.Drawing.Point(3, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 90);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Run Extrapolation";
            // 
            // UsePythonFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 179);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UsePythonFunctions";
            this.Text = "Extrapolate Data";
            this.Load += new System.EventHandler(this.UsePythonFunctions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_CheckAccuracy;
        private Button button_run;
        private ComboBox comboBox_Datasets;
        private ComboBox comboBox_MLAlgorithms;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}