using MigrationPatternSimulation.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MigrationPatternSimulation.Forms
{
    public partial class UsePythonFunctions : Form
    {
        string pythonScriptLocation = @"C:\Users\willi";

        public UsePythonFunctions()
        {
            InitializeComponent();
        }

        private void button_CheckAccuracy_Click(object sender, EventArgs e)
        {
            string dataSet = comboBox_Datasets.SelectedItem.ToString();
            string pathToData = @$"C:\MLExperimentFiles\{dataSet}";
            string script = @"CheckAlgs.py";

            PythonService pythonService = new PythonService(pathToData, pythonScriptLocation, script);
            pythonService.runPythonProcess();

        }

        private void updateButtons()
        {
            if (comboBox_Datasets.SelectedItem != null)
            {
                button_CheckAccuracy.Enabled = true;
            }
            else { button_CheckAccuracy.Enabled = false; }

            if (comboBox_Datasets.SelectedItem != null && comboBox_MLAlgorithms.SelectedItem != null)
            {
                button_run.Enabled = true;
            }
            else { button_run.Enabled = false; }
        }

        private void UsePythonFunctions_Load(object sender, EventArgs e)
        {
            List<FileInfo> csvFiles = new List<FileInfo>();

            foreach(var file in Directory.GetFiles(@"C:\MLExperimentFiles", "*.csv"))
            {
                csvFiles.Add(new FileInfo(file));
            }

            foreach(var file in csvFiles) 
            {
                comboBox_Datasets.Items.Add(file.Name);
            }

            comboBox_MLAlgorithms.Items.Add("LogisticRegression - LR");
            comboBox_MLAlgorithms.Items.Add("LinearDiscriminantAnalysis - LDA");
            comboBox_MLAlgorithms.Items.Add("KNeighborsClassifier - KNN");
            comboBox_MLAlgorithms.Items.Add("DecisionTreeClassifier - CART");
            comboBox_MLAlgorithms.Items.Add("SVC - SVC");
        }

        private void comboBox_Datasets_SelectionChangeCommitted(object sender, EventArgs e)
        {
            updateButtons();
        }

        private void comboBox_MLAlgorithms_SelectionChangeCommitted(object sender, EventArgs e)
        {
            updateButtons();
        }

        private void button_run_Click(object sender, EventArgs e)
        {
            string dataSet = comboBox_Datasets.SelectedItem.ToString();
            string pathToData = @$"C:\MLExperimentFiles\{dataSet}";
            string script = @"runML.py";

            PythonService pythonService = new PythonService(pathToData, pythonScriptLocation, script);
            pythonService.runPythonProcess();
        }
    }
}
