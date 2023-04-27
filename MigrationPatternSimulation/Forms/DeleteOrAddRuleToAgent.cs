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
    public partial class DeleteOrAddRuleToAgent : Form
    {
        LatitudinalAgent agent;
        SimulationController simulationController;

        public DeleteOrAddRuleToAgent(LatitudinalAgent _agent, ref SimulationController controller)
        {
            InitializeComponent();
            agent = _agent;
            simulationController = controller;
        }

        private void DeleteOrAddRuleToAgent_Load(object sender, EventArgs e)
        {
            label_AgentName.Text = agent.speciesName;
        }

        private void button_DeleteAgent_Click(object sender, EventArgs e)
        {
            simulationController.deleteAgent(agent);
            MessageBox.Show(agent.speciesName + " deleted");
            this.Close();
        }

        private void button_AddRule_Click(object sender, EventArgs e)
        {
            AddRuleToAgentForm addRule = new AddRuleToAgentForm(ref agent, ref simulationController);
            addRule.ShowDialog();
        }

        private void button_ViewRules_Click(object sender, EventArgs e)
        {
            ViewAgentsRules viewAgentsRules = new ViewAgentsRules(ref agent);
            viewAgentsRules.ShowDialog();
        }
    }
}
