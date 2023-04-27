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
    public partial class ViewAgentsRules : Form
    {
        LatitudinalAgent agent;

        public ViewAgentsRules(ref LatitudinalAgent _agent)
        {
            InitializeComponent();
            agent = _agent;
            Agent_label.Text = agent.speciesName;

        }

        private void ViewAgentsRules_Load(object sender, EventArgs e)
        {
            populateAgentRules();
        }

        private void populateAgentRules()
        {
            foreach (BirdSim.Rule rule in agent.getRules())
            {
                string greterlessequal;
                if (rule.getGreaterThan())
                {
                    greterlessequal = "Greater Than";
                }
                else if (rule.getLessThan())
                {
                    greterlessequal = "Less Than";
                }
                else
                {
                    greterlessequal = "Equal To";
                }

                string output = $"{rule.getRuleName()}: IF {rule.getRuleTypeAsString()} IS {greterlessequal} {rule.getRuleParameter().ToString()} THEN {rule.getActionAsString()}";

                listBox_AgentRules.Items.Add(output);
            }
        }

        private void listBox_AgentRules_DoubleClick(object sender, EventArgs e)
        {
            if(listBox_AgentRules.SelectedItems.Count > 0)
            {
                DeleteRule_Form deleteRule = new DeleteRule_Form(ref agent, agent.getRules()[listBox_AgentRules.SelectedIndex]);
                deleteRule.ShowDialog();
                updateRules();
            }
        }

        private void updateRules()
        {
            listBox_AgentRules.Items.Clear();
            populateAgentRules();
        }
    }
}
