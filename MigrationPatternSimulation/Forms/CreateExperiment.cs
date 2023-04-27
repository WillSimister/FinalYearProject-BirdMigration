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
    public partial class CreateExperiment : Form
    {
        SimulationController simulationController;

        public CreateExperiment(ref SimulationController simulationController)
        {
            InitializeComponent();
            this.simulationController = simulationController;

            comboBox_SelectAgent.BindingContext = new BindingContext();
            comboBox_SelectAgent.DataSource = simulationController.getAgentsList();
            comboBox_SelectAgent.DisplayMember = "speciesName";

            comboBox_SelectExperiment.BindingContext = new BindingContext();
            comboBox_SelectExperiment.DataSource = simulationController.getEnvironments();
            comboBox_SelectExperiment.DisplayMember = "instanceName";

        }



        private void CreateExperiment_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectAgent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            SimulationInstance simulationInstance = comboBox_SelectExperiment.SelectedItem as SimulationInstance;
            LatitudinalAgent latitudinalAgent = comboBox_SelectAgent.SelectedItem as LatitudinalAgent;
            string name = textBox_ExperimentName.Text + "-" + simulationInstance.InstanceName.Substring(simulationInstance.InstanceName.Length - 4, 4);
            string desc = textBox_Description.Text;
            Experiment experiment = new Experiment(simulationInstance, latitudinalAgent, name, desc, simulationController);
            simulationController.addExperimentToList(experiment);
            this.Close();
        }
    }
}
