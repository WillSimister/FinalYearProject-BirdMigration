using BirdSim;
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
    public partial class DeleteEnvironment : Form
    {
        SimulationController simulationController;
        SimulationInstance simulationInstance;

        public DeleteEnvironment(ref SimulationController simulationController, SimulationInstance instance)
        {
            InitializeComponent();
            this.simulationController = simulationController;
            this.simulationInstance = instance;
        }

        private void label_environmentName_Click(object sender, EventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            simulationController.deleteEnvironment(simulationInstance);
            this.Close();
        }
    }
}
