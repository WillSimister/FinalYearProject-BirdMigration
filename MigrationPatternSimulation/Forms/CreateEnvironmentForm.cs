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
    public partial class CreateEnvironmentForm : Form
    {
        SimulationController controller;

        string instanceName;
        Country northernMostCountry;
        Country southernMostCountry;
        string northNorthCountry;
        string eastNorthCountry;
        string southNorthCountry;
        string westNorthCountry;
        string northSouthCountry;
        string eastSouthCountry;
        string southSouthCountry;
        string westSouthCountry;
        Dictionary<int, double> northernData = new Dictionary<int, double>();
        Dictionary<int, double> southernData = new Dictionary<int, double>();

        public CreateEnvironmentForm(ref SimulationController controller)
        {
            InitializeComponent();
            this.controller = controller;


            listBox_Environments.Items.AddRange(controller.getEnvironments().ToArray());
            listBox_Environments.DisplayMember = "instanceName";

            comboBox_NorthernCountry.BindingContext = new BindingContext();
            comboBox_NorthernCountry.DataSource = controller.getAllCountries();
            comboBox_NorthernCountry.DisplayMember = "name";

            comboBox_NorthernClosestN.BindingContext = new BindingContext();
            comboBox_NorthernClosestN.DataSource = controller.getAllCountries();
            comboBox_NorthernClosestN.DisplayMember = "name";

            comboBox_NorthernClosestE.BindingContext = new BindingContext();
            comboBox_NorthernClosestE.DataSource = controller.getAllCountries();
            comboBox_NorthernClosestE.DisplayMember = "name";

            comboBox_NorthernClosestS.BindingContext = new BindingContext();
            comboBox_NorthernClosestS.DataSource = controller.getAllCountries();
            comboBox_NorthernClosestS.DisplayMember = "name";

            comboBox_NorthernClosestW.BindingContext = new BindingContext();
            comboBox_NorthernClosestW.DataSource = controller.getAllCountries();
            comboBox_NorthernClosestW.DisplayMember = "name";

            comboBox_Southern.BindingContext = new BindingContext();
            comboBox_Southern.DataSource = controller.getAllCountries();
            comboBox_Southern.DisplayMember = "name";

            comboBox_SouthernClosestN.BindingContext = new BindingContext();
            comboBox_SouthernClosestN.DataSource = controller.getAllCountries();
            comboBox_SouthernClosestN.DisplayMember = "name";

            comboBox_SouthernClosestE.BindingContext = new BindingContext();
            comboBox_SouthernClosestE.DataSource = controller.getAllCountries();
            comboBox_SouthernClosestE.DisplayMember = "name";

            comboBox_SouthernClosestS.BindingContext = new BindingContext();
            comboBox_SouthernClosestS.DataSource = controller.getAllCountries();
            comboBox_SouthernClosestS.DisplayMember = "name";

            comboBox_SouthernClosestW.BindingContext = new BindingContext();
            comboBox_SouthernClosestW.DataSource = controller.getAllCountries();
            comboBox_SouthernClosestW.DisplayMember = "name";


        }

        private void CreateEnvironmentForm_Load(object sender, EventArgs e)
        {
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button_CreateEnv_Click(object sender, EventArgs e)
        {
            instanceName = textBox_EnvName.Text + " " +dateTimePicker1.Value.Year.ToString();

            northernMostCountry = comboBox_NorthernCountry.SelectedItem as Country;
            southernMostCountry = comboBox_Southern.SelectedItem as Country;

            //Breeding Country
            northNorthCountry = ((Country)comboBox_NorthernClosestN.SelectedItem).getCode();
            eastNorthCountry = ((Country)comboBox_NorthernClosestE.SelectedItem).getCode();
            southNorthCountry = ((Country)comboBox_NorthernClosestS.SelectedItem).getCode();
            westNorthCountry = ((Country)comboBox_NorthernClosestW.SelectedItem).getCode();

            //Nesting Country
            northSouthCountry = ((Country)comboBox_SouthernClosestN.SelectedItem).getCode();
            eastSouthCountry = ((Country)comboBox_SouthernClosestE.SelectedItem).getCode();
            southSouthCountry = ((Country)comboBox_SouthernClosestS.SelectedItem).getCode();
            westSouthCountry = ((Country)comboBox_SouthernClosestW.SelectedItem).getCode();

            northernMostCountry.setClosestCountries(northNorthCountry, eastNorthCountry, southNorthCountry, westNorthCountry);
            southernMostCountry.setClosestCountries(northSouthCountry, eastSouthCountry, southSouthCountry, westSouthCountry);

            List<Country> environment = new List<Country>
            {
                northernMostCountry,
                southernMostCountry
            };

            SimulationInstance simulationInstance = new SimulationInstance(environment, instanceName);
            controller.addEnvironment(simulationInstance);

            MessageBox.Show("Environment Created");
            this.Close();
        }

        private void button_AddNorthernFile_Click(object sender, EventArgs e)
        {
            string path = "";
            if(openFileDialog_Env.ShowDialog() == DialogResult.OK)
            {
                label_NorthernFileName.Text = openFileDialog_Env.FileName;
                path = openFileDialog_Env.FileName;
            }

            if(path != "")
            {
                parseFileForData(true, path);
            }
        }

        private void parseFileForData(bool isNorthern, string path)
        {
            int counter = 1;

            //Incase the user chooses another file after upload
            if(isNorthern)
            {
                northernData.Clear();
            }
            else 
            {
                southernData.Clear();
            }


            var filestream = new System.IO.FileStream(path,
                                          System.IO.FileMode.Open,
                                          System.IO.FileAccess.Read,
                                          System.IO.FileShare.ReadWrite);
            var file = new System.IO.StreamReader(filestream, System.Text.Encoding.UTF8, true, 1024);
            string lineOfText;
            while ((lineOfText = file.ReadLine()) != null)
            {
                if(isNorthern)
                {
                    northernData.Add(counter, double.Parse(lineOfText));
                    counter++;
                }
                else
                {
                    southernData.Add(counter, double.Parse(lineOfText));
                    counter++;
                }
            }

            if(isNorthern)
            {
                northernMostCountry = comboBox_NorthernCountry.SelectedItem as Country;
                northernMostCountry.setClimateData(northernData);
            }
            else
            {
                southernMostCountry = comboBox_Southern.SelectedItem as Country;
                southernMostCountry.setClimateData(southernData);
            }
        }

        private void comboBox_NorthernCountry_SelectionChangeCommitted(object sender, EventArgs e)
        {
            northernMostCountry = comboBox_NorthernCountry.SelectedItem as Country;
        }

        private void comboBox_Southern_SelectionChangeCommitted(object sender, EventArgs e)
        {
            southernMostCountry = comboBox_Southern.SelectedItem as Country;
        }

        private void button_AddSouthernFile_Click(object sender, EventArgs e)
        {
            string path = "";
            if (openFileDialog_Env.ShowDialog() == DialogResult.OK)
            {
                label_SouthernFileName.Text = openFileDialog_Env.FileName;
                path = openFileDialog_Env.FileName;
            }

            if (path != "")
            {
                parseFileForData(false, path);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox_Environments.SelectedItem != null)
            {
                SimulationInstance env = listBox_Environments.SelectedItem as SimulationInstance;

                textBox_EnvName.Text = env.InstanceName.Remove(env.InstanceName.Length - 5);
                textBox_EnvName.Enabled = false;

                Country north = env.Countries[0];
                comboBox_NorthernCountry.SelectedItem = north;

                //Breeding Country
                comboBox_NorthernClosestN.SelectedIndex = controller.countryObjects.IndexOf(controller.countryObjects.FirstOrDefault(x => x.getCode() == north.getClosestNorthern()));
                comboBox_NorthernClosestE.SelectedIndex = controller.countryObjects.IndexOf(controller.countryObjects.FirstOrDefault(x => x.getCode() == north.getClosestEastern()));
                comboBox_NorthernClosestS.SelectedIndex = controller.countryObjects.IndexOf(controller.countryObjects.FirstOrDefault(x => x.getCode() == north.getClosestSouthern()));
                comboBox_NorthernClosestW.SelectedIndex = controller.countryObjects.IndexOf(controller.countryObjects.FirstOrDefault(x => x.getCode() == north.getClosestWestern()));

                Country south = env.Countries[1];
                comboBox_Southern.SelectedItem = south;

                //Nesting Country
                comboBox_SouthernClosestN.SelectedIndex = controller.countryObjects.IndexOf(controller.countryObjects.FirstOrDefault(x => x.getCode() == south.getClosestNorthern()));
                comboBox_SouthernClosestE.SelectedIndex = controller.countryObjects.IndexOf(controller.countryObjects.FirstOrDefault(x => x.getCode() == south.getClosestEastern()));
                comboBox_SouthernClosestS.SelectedIndex = controller.countryObjects.IndexOf(controller.countryObjects.FirstOrDefault(x => x.getCode() == south.getClosestSouthern()));
                comboBox_SouthernClosestW.SelectedIndex = controller.countryObjects.IndexOf(controller.countryObjects.FirstOrDefault(x => x.getCode() == south.getClosestWestern()));
            }
        }
    }
}
