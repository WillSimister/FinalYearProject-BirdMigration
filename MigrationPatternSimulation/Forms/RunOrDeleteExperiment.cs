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
    public partial class RunOrDeleteExperiment : Form
    {
        SimulationController simulationController;
        Experiment experiment;

        public RunOrDeleteExperiment(ref SimulationController simulationController, Experiment experiment)
        {
            InitializeComponent();
            this.simulationController = simulationController;
            this.experiment = experiment;
           
        }

        private void RunOrDeleteExperiment_Load(object sender, EventArgs e)
        {
            label_ExpName.Text = experiment.experimentName;
            label_ExpDesc.Text = experiment.experimentDescription;
        }

        private void button_Run_Click(object sender, EventArgs e)
        {
            experiment.runExperiment();
            MessageBox.Show("Experiment has finished running, for logs go to folder");
            this.Close();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            simulationController.deleteExperiment(experiment);
            MessageBox.Show("Experiment Deleted");
            this.Close();
        }
    }
}
