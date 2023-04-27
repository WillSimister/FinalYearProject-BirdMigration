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
    public partial class AddRuleToAgentForm : Form
    {
        LatitudinalAgent agent;
        SimulationController simulationController;
        string ruleName;
        ruleTypeEnum simulationProperty;
        ActionEnum simulationAction;
        SimulationProperty? simulationProperty2;
        int propertyValue;
        bool greaterThan = false;
        bool lessthan = false;
        bool equalTo = false;

        public AddRuleToAgentForm(ref LatitudinalAgent _agent, ref SimulationController controller)
        {
            InitializeComponent();
            agent = _agent;
            simulationController = controller;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AddRuleToAgentForm_Load(object sender, EventArgs e)
        {
            label_AgentName.Text = agent.speciesName;
            //Simulation Properties Combo box
            comboBox_SimProp.Items.Add("Month");
            comboBox_SimProp.Items.Add("Temperature");

            //Comparator Combo Box
            comboBox_Comparator.Items.Add("Greater than");
            comboBox_Comparator.Items.Add("Less than");
            comboBox_Comparator.Items.Add("Equal To");

            //Decision Combo Box
            comboBox_Decision.Items.Add("Migrate to Breeding Grounds");
            comboBox_Decision.Items.Add("Migrate to Nesting Grounds");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ruleName = textBox_RuleName.Text;

            switch (comboBox_SimProp.SelectedIndex)
            {
                case 0:
                    {
                        simulationProperty = ruleTypeEnum.Month;
                        break;
                    }
                case 1:
                    {
                        simulationProperty = ruleTypeEnum.ClimateTemp;
                        break;
                    }
                default:
                    {
                        //do nothing
                        break;
                    }
            }

            switch (comboBox_Comparator.SelectedIndex)
            {
                case 0:
                    {
                        greaterThan = true;
                        break;
                    }
                case 1:
                    {
                        lessthan = true;
                        break;
                    }
                case 2:
                    {
                        equalTo = true;
                        break;
                    }
            }

            switch (comboBox_Decision.SelectedIndex)
            {
                case 0:
                    {
                        simulationAction = ActionEnum.migrateNorth;
                        break;
                    }
                case 1:
                    {
                        simulationAction = ActionEnum.migrateSouth;
                        break;
                    }
            }

            propertyValue = ((int)numericUpDown_Value.Value);

            BirdSim.Rule rule = new BirdSim.Rule(ruleName, simulationProperty, greaterThan, lessthan, equalTo, false, false, propertyValue, simulationAction);
            agent.addRule(rule);
            MessageBox.Show("Rule Created and Added to Agents list of rules");
            this.Close();
        }

        private void label_AgentName_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_SimProp_SelectedIndexChanged(object sender, EventArgs e)
        {
            simProp_label.Text = comboBox_SimProp.Text;
            tryValidate();
        }

        private void comboBox_Comparator_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_Comparator.Text = comboBox_Comparator.Text;
            tryValidate();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label_value.Text = numericUpDown_Value.Value.ToString(); 
            tryValidate();
        }

        private void comboBox_Decision_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_Decision.Text = comboBox_Decision.Text;
            tryValidate();
        }

        private void tryValidate()
        {
            if(textBox_RuleName.Text.Length > 0 && comboBox_SimProp.SelectedIndex > -1 && comboBox_Comparator.SelectedIndex > -1 && comboBox_Decision.SelectedIndex > 0)
            {
                button_CreateRule.Enabled = true;
            }
        }
    }
}
