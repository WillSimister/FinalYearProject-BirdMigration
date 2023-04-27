namespace MigrationPatternSimulation.Forms
{
    partial class CreateEnvironmentForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_NorthernFileName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_AddNorthernFile = new System.Windows.Forms.Button();
            this.comboBox_NorthernClosestW = new System.Windows.Forms.ComboBox();
            this.comboBox_NorthernClosestS = new System.Windows.Forms.ComboBox();
            this.comboBox_NorthernClosestE = new System.Windows.Forms.ComboBox();
            this.comboBox_NorthernClosestN = new System.Windows.Forms.ComboBox();
            this.comboBox_NorthernCountry = new System.Windows.Forms.ComboBox();
            this.textBox_EnvName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_SouthernFileName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_AddSouthernFile = new System.Windows.Forms.Button();
            this.comboBox_SouthernClosestW = new System.Windows.Forms.ComboBox();
            this.comboBox_SouthernClosestS = new System.Windows.Forms.ComboBox();
            this.comboBox_SouthernClosestE = new System.Windows.Forms.ComboBox();
            this.comboBox_SouthernClosestN = new System.Windows.Forms.ComboBox();
            this.comboBox_Southern = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button_CreateEnv = new System.Windows.Forms.Button();
            this.openFileDialog_Env = new System.Windows.Forms.OpenFileDialog();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox_Environments = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Environment Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Northern Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Closest Northern Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Closest Eastern Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Closest Southern Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Closest Western Country";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_NorthernFileName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button_AddNorthernFile);
            this.groupBox1.Controls.Add(this.comboBox_NorthernClosestW);
            this.groupBox1.Controls.Add(this.comboBox_NorthernClosestS);
            this.groupBox1.Controls.Add(this.comboBox_NorthernClosestE);
            this.groupBox1.Controls.Add(this.comboBox_NorthernClosestN);
            this.groupBox1.Controls.Add(this.comboBox_NorthernCountry);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 360);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Northern Country";
            // 
            // label_NorthernFileName
            // 
            this.label_NorthernFileName.AutoSize = true;
            this.label_NorthernFileName.Location = new System.Drawing.Point(106, 319);
            this.label_NorthernFileName.Name = "label_NorthernFileName";
            this.label_NorthernFileName.Size = new System.Drawing.Size(18, 20);
            this.label_NorthernFileName.TabIndex = 14;
            this.label_NorthernFileName.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Add Environment File";
            // 
            // button_AddNorthernFile
            // 
            this.button_AddNorthernFile.Location = new System.Drawing.Point(6, 315);
            this.button_AddNorthernFile.Name = "button_AddNorthernFile";
            this.button_AddNorthernFile.Size = new System.Drawing.Size(94, 29);
            this.button_AddNorthernFile.TabIndex = 11;
            this.button_AddNorthernFile.Text = "Open...";
            this.button_AddNorthernFile.UseVisualStyleBackColor = true;
            this.button_AddNorthernFile.Click += new System.EventHandler(this.button_AddNorthernFile_Click);
            // 
            // comboBox_NorthernClosestW
            // 
            this.comboBox_NorthernClosestW.FormattingEnabled = true;
            this.comboBox_NorthernClosestW.Location = new System.Drawing.Point(6, 261);
            this.comboBox_NorthernClosestW.Name = "comboBox_NorthernClosestW";
            this.comboBox_NorthernClosestW.Size = new System.Drawing.Size(414, 28);
            this.comboBox_NorthernClosestW.TabIndex = 10;
            // 
            // comboBox_NorthernClosestS
            // 
            this.comboBox_NorthernClosestS.FormattingEnabled = true;
            this.comboBox_NorthernClosestS.Location = new System.Drawing.Point(6, 207);
            this.comboBox_NorthernClosestS.Name = "comboBox_NorthernClosestS";
            this.comboBox_NorthernClosestS.Size = new System.Drawing.Size(414, 28);
            this.comboBox_NorthernClosestS.TabIndex = 9;
            // 
            // comboBox_NorthernClosestE
            // 
            this.comboBox_NorthernClosestE.FormattingEnabled = true;
            this.comboBox_NorthernClosestE.Location = new System.Drawing.Point(6, 154);
            this.comboBox_NorthernClosestE.Name = "comboBox_NorthernClosestE";
            this.comboBox_NorthernClosestE.Size = new System.Drawing.Size(414, 28);
            this.comboBox_NorthernClosestE.TabIndex = 8;
            // 
            // comboBox_NorthernClosestN
            // 
            this.comboBox_NorthernClosestN.FormattingEnabled = true;
            this.comboBox_NorthernClosestN.Location = new System.Drawing.Point(6, 100);
            this.comboBox_NorthernClosestN.Name = "comboBox_NorthernClosestN";
            this.comboBox_NorthernClosestN.Size = new System.Drawing.Size(414, 28);
            this.comboBox_NorthernClosestN.TabIndex = 7;
            // 
            // comboBox_NorthernCountry
            // 
            this.comboBox_NorthernCountry.FormattingEnabled = true;
            this.comboBox_NorthernCountry.Location = new System.Drawing.Point(6, 46);
            this.comboBox_NorthernCountry.Name = "comboBox_NorthernCountry";
            this.comboBox_NorthernCountry.Size = new System.Drawing.Size(414, 28);
            this.comboBox_NorthernCountry.TabIndex = 6;
            this.comboBox_NorthernCountry.SelectionChangeCommitted += new System.EventHandler(this.comboBox_NorthernCountry_SelectionChangeCommitted);
            // 
            // textBox_EnvName
            // 
            this.textBox_EnvName.Location = new System.Drawing.Point(12, 32);
            this.textBox_EnvName.Name = "textBox_EnvName";
            this.textBox_EnvName.Size = new System.Drawing.Size(426, 27);
            this.textBox_EnvName.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_SouthernFileName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button_AddSouthernFile);
            this.groupBox2.Controls.Add(this.comboBox_SouthernClosestW);
            this.groupBox2.Controls.Add(this.comboBox_SouthernClosestS);
            this.groupBox2.Controls.Add(this.comboBox_SouthernClosestE);
            this.groupBox2.Controls.Add(this.comboBox_SouthernClosestN);
            this.groupBox2.Controls.Add(this.comboBox_Southern);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(455, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 360);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Southern Country";
            // 
            // label_SouthernFileName
            // 
            this.label_SouthernFileName.AutoSize = true;
            this.label_SouthernFileName.Location = new System.Drawing.Point(106, 319);
            this.label_SouthernFileName.Name = "label_SouthernFileName";
            this.label_SouthernFileName.Size = new System.Drawing.Size(18, 20);
            this.label_SouthernFileName.TabIndex = 13;
            this.label_SouthernFileName.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Add Environment File";
            // 
            // button_AddSouthernFile
            // 
            this.button_AddSouthernFile.Location = new System.Drawing.Point(6, 315);
            this.button_AddSouthernFile.Name = "button_AddSouthernFile";
            this.button_AddSouthernFile.Size = new System.Drawing.Size(94, 29);
            this.button_AddSouthernFile.TabIndex = 11;
            this.button_AddSouthernFile.Text = "Open...";
            this.button_AddSouthernFile.UseVisualStyleBackColor = true;
            this.button_AddSouthernFile.Click += new System.EventHandler(this.button_AddSouthernFile_Click);
            // 
            // comboBox_SouthernClosestW
            // 
            this.comboBox_SouthernClosestW.FormattingEnabled = true;
            this.comboBox_SouthernClosestW.Location = new System.Drawing.Point(6, 261);
            this.comboBox_SouthernClosestW.Name = "comboBox_SouthernClosestW";
            this.comboBox_SouthernClosestW.Size = new System.Drawing.Size(414, 28);
            this.comboBox_SouthernClosestW.TabIndex = 10;
            // 
            // comboBox_SouthernClosestS
            // 
            this.comboBox_SouthernClosestS.FormattingEnabled = true;
            this.comboBox_SouthernClosestS.Location = new System.Drawing.Point(6, 207);
            this.comboBox_SouthernClosestS.Name = "comboBox_SouthernClosestS";
            this.comboBox_SouthernClosestS.Size = new System.Drawing.Size(414, 28);
            this.comboBox_SouthernClosestS.TabIndex = 9;
            // 
            // comboBox_SouthernClosestE
            // 
            this.comboBox_SouthernClosestE.FormattingEnabled = true;
            this.comboBox_SouthernClosestE.Location = new System.Drawing.Point(6, 154);
            this.comboBox_SouthernClosestE.Name = "comboBox_SouthernClosestE";
            this.comboBox_SouthernClosestE.Size = new System.Drawing.Size(414, 28);
            this.comboBox_SouthernClosestE.TabIndex = 8;
            // 
            // comboBox_SouthernClosestN
            // 
            this.comboBox_SouthernClosestN.FormattingEnabled = true;
            this.comboBox_SouthernClosestN.Location = new System.Drawing.Point(6, 100);
            this.comboBox_SouthernClosestN.Name = "comboBox_SouthernClosestN";
            this.comboBox_SouthernClosestN.Size = new System.Drawing.Size(414, 28);
            this.comboBox_SouthernClosestN.TabIndex = 7;
            // 
            // comboBox_Southern
            // 
            this.comboBox_Southern.FormattingEnabled = true;
            this.comboBox_Southern.Location = new System.Drawing.Point(6, 46);
            this.comboBox_Southern.Name = "comboBox_Southern";
            this.comboBox_Southern.Size = new System.Drawing.Size(414, 28);
            this.comboBox_Southern.TabIndex = 6;
            this.comboBox_Southern.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Southern_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Southern Country";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Closest Western Country";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Closest Eastern Country";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Closest Southern Country";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Closest Northern Country";
            // 
            // button_CreateEnv
            // 
            this.button_CreateEnv.Location = new System.Drawing.Point(12, 438);
            this.button_CreateEnv.Name = "button_CreateEnv";
            this.button_CreateEnv.Size = new System.Drawing.Size(94, 29);
            this.button_CreateEnv.TabIndex = 14;
            this.button_CreateEnv.Text = "Create...";
            this.button_CreateEnv.UseVisualStyleBackColor = true;
            this.button_CreateEnv.Click += new System.EventHandler(this.button_CreateEnv_Click);
            // 
            // openFileDialog_Env
            // 
            this.openFileDialog_Env.DefaultExt = "txt";
            this.openFileDialog_Env.FileName = "openFileDialog1";
            this.openFileDialog_Env.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFileDialog_Env.InitialDirectory = "@\"C:\\\"";
            this.openFileDialog_Env.RestoreDirectory = true;
            this.openFileDialog_Env.Title = "Select Environment File";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(455, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "Environment Year";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(455, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(733, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "Copy Environment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox_Environments
            // 
            this.listBox_Environments.BackColor = System.Drawing.Color.YellowGreen;
            this.listBox_Environments.FormattingEnabled = true;
            this.listBox_Environments.ItemHeight = 20;
            this.listBox_Environments.Location = new System.Drawing.Point(887, 30);
            this.listBox_Environments.Name = "listBox_Environments";
            this.listBox_Environments.Size = new System.Drawing.Size(361, 404);
            this.listBox_Environments.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(887, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(153, 20);
            this.label15.TabIndex = 19;
            this.label15.Text = "Existing Environments";
            // 
            // CreateEnvironmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 475);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.listBox_Environments);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button_CreateEnv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox_EnvName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "CreateEnvironmentForm";
            this.Text = "Create New Environment";
            this.Load += new System.EventHandler(this.CreateEnvironmentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private ComboBox comboBox_NorthernClosestW;
        private ComboBox comboBox_NorthernClosestS;
        private ComboBox comboBox_NorthernClosestE;
        private ComboBox comboBox_NorthernClosestN;
        private ComboBox comboBox_NorthernCountry;
        private TextBox textBox_EnvName;
        private Button button_AddNorthernFile;
        private Label label_NorthernFileName;
        private Label label7;
        private GroupBox groupBox2;
        private Label label_SouthernFileName;
        private Label label8;
        private Button button_AddSouthernFile;
        private ComboBox comboBox_SouthernClosestW;
        private ComboBox comboBox_SouthernClosestS;
        private ComboBox comboBox_SouthernClosestE;
        private ComboBox comboBox_SouthernClosestN;
        private ComboBox comboBox_Southern;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button button_CreateEnv;
        private OpenFileDialog openFileDialog_Env;
        private Label label14;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private ListBox listBox_Environments;
        private Label label15;
    }
}