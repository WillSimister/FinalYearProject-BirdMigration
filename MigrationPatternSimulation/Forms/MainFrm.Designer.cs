namespace MigrationPatternSimulation
{
    partial class MainFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_Agents = new System.Windows.Forms.ListBox();
            this.listBox_Environments = new System.Windows.Forms.ListBox();
            this.listBox_Experiments = new System.Windows.Forms.ListBox();
            this.label_agents = new System.Windows.Forms.Label();
            this.label_Environments = new System.Windows.Forms.Label();
            this.label_Experiments = new System.Windows.Forms.Label();
            this.button_newAgent = new System.Windows.Forms.Button();
            this.button_CreateEnvironment = new System.Windows.Forms.Button();
            this.button_NewExperiment = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_ProduceRegression = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Agents
            // 
            this.listBox_Agents.FormattingEnabled = true;
            this.listBox_Agents.ItemHeight = 20;
            this.listBox_Agents.Location = new System.Drawing.Point(5, 30);
            this.listBox_Agents.Name = "listBox_Agents";
            this.listBox_Agents.Size = new System.Drawing.Size(318, 364);
            this.listBox_Agents.TabIndex = 0;
            this.listBox_Agents.DoubleClick += new System.EventHandler(this.listBox_Agents_DoubleClick);
            // 
            // listBox_Environments
            // 
            this.listBox_Environments.FormattingEnabled = true;
            this.listBox_Environments.ItemHeight = 20;
            this.listBox_Environments.Location = new System.Drawing.Point(364, 30);
            this.listBox_Environments.Name = "listBox_Environments";
            this.listBox_Environments.Size = new System.Drawing.Size(318, 364);
            this.listBox_Environments.TabIndex = 1;
            this.listBox_Environments.DoubleClick += new System.EventHandler(this.listBox_Environments_DoubleClick);
            // 
            // listBox_Experiments
            // 
            this.listBox_Experiments.FormattingEnabled = true;
            this.listBox_Experiments.ItemHeight = 20;
            this.listBox_Experiments.Location = new System.Drawing.Point(723, 30);
            this.listBox_Experiments.Name = "listBox_Experiments";
            this.listBox_Experiments.Size = new System.Drawing.Size(318, 364);
            this.listBox_Experiments.TabIndex = 2;
            this.listBox_Experiments.DoubleClick += new System.EventHandler(this.listBox_Experiments_DoubleClick);
            // 
            // label_agents
            // 
            this.label_agents.AutoSize = true;
            this.label_agents.Location = new System.Drawing.Point(5, 7);
            this.label_agents.Name = "label_agents";
            this.label_agents.Size = new System.Drawing.Size(55, 20);
            this.label_agents.TabIndex = 3;
            this.label_agents.Text = "Agents";
            // 
            // label_Environments
            // 
            this.label_Environments.AutoSize = true;
            this.label_Environments.Location = new System.Drawing.Point(364, 7);
            this.label_Environments.Name = "label_Environments";
            this.label_Environments.Size = new System.Drawing.Size(98, 20);
            this.label_Environments.TabIndex = 4;
            this.label_Environments.Text = "Environments";
            // 
            // label_Experiments
            // 
            this.label_Experiments.AutoSize = true;
            this.label_Experiments.Location = new System.Drawing.Point(723, 7);
            this.label_Experiments.Name = "label_Experiments";
            this.label_Experiments.Size = new System.Drawing.Size(98, 20);
            this.label_Experiments.TabIndex = 5;
            this.label_Experiments.Text = "Experiements";
            // 
            // button_newAgent
            // 
            this.button_newAgent.Location = new System.Drawing.Point(5, 400);
            this.button_newAgent.Name = "button_newAgent";
            this.button_newAgent.Size = new System.Drawing.Size(151, 29);
            this.button_newAgent.TabIndex = 6;
            this.button_newAgent.Text = "New Agent";
            this.button_newAgent.UseVisualStyleBackColor = true;
            this.button_newAgent.Click += new System.EventHandler(this.button_newAgent_Click);
            // 
            // button_CreateEnvironment
            // 
            this.button_CreateEnvironment.Location = new System.Drawing.Point(364, 400);
            this.button_CreateEnvironment.Name = "button_CreateEnvironment";
            this.button_CreateEnvironment.Size = new System.Drawing.Size(141, 29);
            this.button_CreateEnvironment.TabIndex = 7;
            this.button_CreateEnvironment.Text = "New Environment";
            this.button_CreateEnvironment.UseVisualStyleBackColor = true;
            this.button_CreateEnvironment.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_NewExperiment
            // 
            this.button_NewExperiment.Location = new System.Drawing.Point(723, 400);
            this.button_NewExperiment.Name = "button_NewExperiment";
            this.button_NewExperiment.Size = new System.Drawing.Size(146, 29);
            this.button_NewExperiment.TabIndex = 8;
            this.button_NewExperiment.Text = "New Experiment";
            this.button_NewExperiment.UseVisualStyleBackColor = true;
            this.button_NewExperiment.Click += new System.EventHandler(this.button_NewExperiment_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(875, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Compile Experiments";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_ProduceRegression
            // 
            this.button_ProduceRegression.Location = new System.Drawing.Point(875, 435);
            this.button_ProduceRegression.Name = "button_ProduceRegression";
            this.button_ProduceRegression.Size = new System.Drawing.Size(166, 29);
            this.button_ProduceRegression.TabIndex = 10;
            this.button_ProduceRegression.Text = "Produce Regression";
            this.button_ProduceRegression.UseVisualStyleBackColor = true;
            this.button_ProduceRegression.Click += new System.EventHandler(this.button_ProduceRegression_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 477);
            this.Controls.Add(this.button_ProduceRegression);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_NewExperiment);
            this.Controls.Add(this.button_CreateEnvironment);
            this.Controls.Add(this.button_newAgent);
            this.Controls.Add(this.label_Experiments);
            this.Controls.Add(this.label_Environments);
            this.Controls.Add(this.label_agents);
            this.Controls.Add(this.listBox_Experiments);
            this.Controls.Add(this.listBox_Environments);
            this.Controls.Add(this.listBox_Agents);
            this.Name = "MainFrm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox_Agents;
        private ListBox listBox_Environments;
        private ListBox listBox_Experiments;
        private Label label_agents;
        private Label label_Environments;
        private Label label_Experiments;
        private Button button_newAgent;
        private Button button_CreateEnvironment;
        private Button button_NewExperiment;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private Button button_ProduceRegression;
    }
}