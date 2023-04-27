using BirdSim;
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
    public partial class CompileExperimentOutputs : Form
    {
        SimulationController SimulationController;
        List<Experiment> experiments = new List<Experiment>();
        string name;

        public CompileExperimentOutputs(ref SimulationController simulationController, string name)
        {
            InitializeComponent();
            this.name = name;
            this.SimulationController = simulationController;
            loadExpSets();

        }

        private void loadExpSets()
        {
            List<string> expNames = new List<string>();

            foreach (Experiment experiment in SimulationController.getExperiments())
            {
                if (!expNames.Contains(experiment.experimentName.Remove(experiment.experimentName.Length - 5)))
                {
                    expNames.Add(experiment.experimentName.Remove(experiment.experimentName.Length - 5));
                }
            }
            comboBox1.Items.AddRange(expNames.ToArray());
        }

        private void CompileExperimentOutputs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MachineLearningDataCompiler compiler = new MachineLearningDataCompiler(comboBox1.Text, name.Remove(0, name.Length));
            
            compiler.compileMLDataset();
            MessageBox.Show("Compiled the experiments successfully");
            this.Close();
        }
    }
}
