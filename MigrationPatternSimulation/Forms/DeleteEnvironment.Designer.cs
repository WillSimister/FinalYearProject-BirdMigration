namespace MigrationPatternSimulation.Forms
{
    partial class DeleteEnvironment
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
            this.button_delete = new System.Windows.Forms.Button();
            this.label_environmentName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(34, 52);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(94, 29);
            this.button_delete.TabIndex = 0;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label_environmentName
            // 
            this.label_environmentName.AutoSize = true;
            this.label_environmentName.Location = new System.Drawing.Point(55, 29);
            this.label_environmentName.Name = "label_environmentName";
            this.label_environmentName.Size = new System.Drawing.Size(50, 20);
            this.label_environmentName.TabIndex = 1;
            this.label_environmentName.Text = "label1";
            this.label_environmentName.Click += new System.EventHandler(this.label_environmentName_Click);
            // 
            // DeleteEnvironment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 113);
            this.Controls.Add(this.label_environmentName);
            this.Controls.Add(this.button_delete);
            this.Name = "DeleteEnvironment";
            this.Text = "Delete Environment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_delete;
        private Label label_environmentName;
    }
}