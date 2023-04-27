namespace MigrationPatternSimulation.Forms
{
    partial class RunOrDeleteExperiment
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
            this.button_Run = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_ExpName = new System.Windows.Forms.Label();
            this.label_ExpDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Experiment Name: ";
            // 
            // button_Run
            // 
            this.button_Run.Location = new System.Drawing.Point(12, 52);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(94, 29);
            this.button_Run.TabIndex = 1;
            this.button_Run.Text = "Run";
            this.button_Run.UseVisualStyleBackColor = true;
            this.button_Run.Click += new System.EventHandler(this.button_Run_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(112, 52);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(94, 29);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Experiment Description: ";
            // 
            // label_ExpName
            // 
            this.label_ExpName.AutoSize = true;
            this.label_ExpName.Location = new System.Drawing.Point(142, 9);
            this.label_ExpName.Name = "label_ExpName";
            this.label_ExpName.Size = new System.Drawing.Size(50, 20);
            this.label_ExpName.TabIndex = 4;
            this.label_ExpName.Text = "label3";
            // 
            // label_ExpDesc
            // 
            this.label_ExpDesc.AutoSize = true;
            this.label_ExpDesc.Location = new System.Drawing.Point(177, 29);
            this.label_ExpDesc.Name = "label_ExpDesc";
            this.label_ExpDesc.Size = new System.Drawing.Size(50, 20);
            this.label_ExpDesc.TabIndex = 5;
            this.label_ExpDesc.Text = "label4";
            // 
            // RunOrDeleteExperiment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 90);
            this.Controls.Add(this.label_ExpDesc);
            this.Controls.Add(this.label_ExpName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Run);
            this.Controls.Add(this.label1);
            this.Name = "RunOrDeleteExperiment";
            this.Text = "Experiment Options";
            this.Load += new System.EventHandler(this.RunOrDeleteExperiment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button_Run;
        private Button button_Delete;
        private Label label2;
        private Label label_ExpName;
        private Label label_ExpDesc;
    }
}