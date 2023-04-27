namespace MigrationPatternSimulation.Forms
{
    partial class DeleteOrAddRuleToAgent
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
            this.label_AgentName = new System.Windows.Forms.Label();
            this.button_AddRule = new System.Windows.Forms.Button();
            this.button_ViewRules = new System.Windows.Forms.Button();
            this.button_DeleteAgent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_AgentName
            // 
            this.label_AgentName.AutoSize = true;
            this.label_AgentName.Location = new System.Drawing.Point(117, 9);
            this.label_AgentName.Name = "label_AgentName";
            this.label_AgentName.Size = new System.Drawing.Size(89, 20);
            this.label_AgentName.TabIndex = 0;
            this.label_AgentName.Text = "AgentName";
            // 
            // button_AddRule
            // 
            this.button_AddRule.Location = new System.Drawing.Point(12, 47);
            this.button_AddRule.Name = "button_AddRule";
            this.button_AddRule.Size = new System.Drawing.Size(94, 29);
            this.button_AddRule.TabIndex = 1;
            this.button_AddRule.Text = "Add Rule";
            this.button_AddRule.UseVisualStyleBackColor = true;
            this.button_AddRule.Click += new System.EventHandler(this.button_AddRule_Click);
            // 
            // button_ViewRules
            // 
            this.button_ViewRules.Location = new System.Drawing.Point(112, 47);
            this.button_ViewRules.Name = "button_ViewRules";
            this.button_ViewRules.Size = new System.Drawing.Size(94, 29);
            this.button_ViewRules.TabIndex = 2;
            this.button_ViewRules.Text = "View Rules";
            this.button_ViewRules.UseVisualStyleBackColor = true;
            this.button_ViewRules.Click += new System.EventHandler(this.button_ViewRules_Click);
            // 
            // button_DeleteAgent
            // 
            this.button_DeleteAgent.Location = new System.Drawing.Point(212, 47);
            this.button_DeleteAgent.Name = "button_DeleteAgent";
            this.button_DeleteAgent.Size = new System.Drawing.Size(94, 29);
            this.button_DeleteAgent.TabIndex = 3;
            this.button_DeleteAgent.Text = "Delete";
            this.button_DeleteAgent.UseVisualStyleBackColor = true;
            this.button_DeleteAgent.Click += new System.EventHandler(this.button_DeleteAgent_Click);
            // 
            // DeleteOrAddRuleToAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 88);
            this.Controls.Add(this.button_DeleteAgent);
            this.Controls.Add(this.button_ViewRules);
            this.Controls.Add(this.button_AddRule);
            this.Controls.Add(this.label_AgentName);
            this.Name = "DeleteOrAddRuleToAgent";
            this.Text = "Agent Options";
            this.Load += new System.EventHandler(this.DeleteOrAddRuleToAgent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_AgentName;
        private Button button_AddRule;
        private Button button_ViewRules;
        private Button button_DeleteAgent;
    }
}