namespace MigrationPatternSimulation.Forms
{
    partial class DeleteRule_Form
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
            this.label_RuleName = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_RuleName
            // 
            this.label_RuleName.AutoSize = true;
            this.label_RuleName.Location = new System.Drawing.Point(86, 9);
            this.label_RuleName.Name = "label_RuleName";
            this.label_RuleName.Size = new System.Drawing.Size(50, 20);
            this.label_RuleName.TabIndex = 0;
            this.label_RuleName.Text = "label1";
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(61, 38);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(94, 29);
            this.button_Delete.TabIndex = 1;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // DeleteRule_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 79);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.label_RuleName);
            this.Name = "DeleteRule_Form";
            this.Text = "Delete Rule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_RuleName;
        private Button button_Delete;
    }
}