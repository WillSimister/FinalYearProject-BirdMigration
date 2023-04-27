namespace MigrationPatternSimulation.Forms
{
    partial class ViewAgentsRules
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
            this.components = new System.ComponentModel.Container();
            this.Agent_label = new System.Windows.Forms.Label();
            this.ruleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox_AgentRules = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ruleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Agent_label
            // 
            this.Agent_label.AutoSize = true;
            this.Agent_label.Location = new System.Drawing.Point(3, 9);
            this.Agent_label.Name = "Agent_label";
            this.Agent_label.Size = new System.Drawing.Size(50, 20);
            this.Agent_label.TabIndex = 0;
            this.Agent_label.Text = "label1";
            // 
            // ruleBindingSource
            // 
            this.ruleBindingSource.DataSource = typeof(BirdSim.Rule);
            // 
            // listBox_AgentRules
            // 
            this.listBox_AgentRules.FormattingEnabled = true;
            this.listBox_AgentRules.ItemHeight = 20;
            this.listBox_AgentRules.Location = new System.Drawing.Point(3, 32);
            this.listBox_AgentRules.Name = "listBox_AgentRules";
            this.listBox_AgentRules.Size = new System.Drawing.Size(793, 404);
            this.listBox_AgentRules.TabIndex = 1;
            this.listBox_AgentRules.DoubleClick += new System.EventHandler(this.listBox_AgentRules_DoubleClick);
            // 
            // ViewAgentsRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.listBox_AgentRules);
            this.Controls.Add(this.Agent_label);
            this.Name = "ViewAgentsRules";
            this.Text = "Agents Rules";
            this.Load += new System.EventHandler(this.ViewAgentsRules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ruleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Agent_label;
        private BindingSource ruleBindingSource;
        private ListBox listBox_AgentRules;
    }
}