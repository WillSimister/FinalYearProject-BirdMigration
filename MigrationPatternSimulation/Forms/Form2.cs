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
using System.Xml.Linq;

namespace MigrationPatternSimulation.Forms
{
    public partial class CreateAgent_Form : Form
    {
        Country BreedingCountry;
        Country NestingCountry;
        bool firstLoadNest = true;
        bool firstLoadBreed = true;

        SimulationController simulationController;

        public CreateAgent_Form(SimulationController simulationController)
        {
            InitializeComponent();
            this.simulationController = simulationController;
            comboBox_BreedingCountry.BindingContext = new BindingContext();
            comboBox_BreedingCountry.DataSource = simulationController.getAllCountries();
            comboBox_BreedingCountry.DisplayMember = "name";

            comboBox_nestingCountry.BindingContext = new BindingContext();
            comboBox_nestingCountry.DataSource = simulationController.getAllCountries();
            comboBox_nestingCountry.DisplayMember = "name";

            comboBox_JanuaryCountry.DisplayMember = "name";
        }

        private void comboBox_BreedingCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(firstLoadBreed)
            {
                firstLoadBreed = false;
            }
            else
            {
                BreedingCountry = (Country)comboBox_BreedingCountry.SelectedItem;
                comboBox_JanuaryCountry.Items.Insert(0, BreedingCountry);
            }
            tryValidate();

        }

        private void comboBox_nestingCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(firstLoadNest) 
            {
                firstLoadNest = false;
            }
            else
            {
                NestingCountry = (Country)comboBox_nestingCountry.SelectedItem;
                comboBox_JanuaryCountry.Items.Insert(1, NestingCountry);
            }
            tryValidate();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Country> _countries = simulationController.getAllCountries();

        }

        private void buttonCreateAgent_Click(object sender, EventArgs e)
        {
            LatitudinalAgent agent = new LatitudinalAgent(textBox1.Text, ((int)numericUpDown_nestingMigrationMonth.Value), ((int)numericUpDown_BreedingMigrationMonth.Value), (Country)comboBox_BreedingCountry.SelectedItem, (Country)comboBox_nestingCountry.SelectedItem, (Country)comboBox_JanuaryCountry.SelectedItem);
            simulationController.addAgentToAgentsList(agent);
            
            this.Close();
        }



        private void tryValidate()
        {
            if(textBox1.Text.Length > 0 && comboBox_BreedingCountry.SelectedIndex > 0 && comboBox_nestingCountry.SelectedIndex > 0 && comboBox_JanuaryCountry.SelectedIndex > 0) 
            {
                button_CreateAgent.Enabled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Do nothing
        }

        private void comboBox_JanuaryCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            tryValidate();
        }
    }
}
