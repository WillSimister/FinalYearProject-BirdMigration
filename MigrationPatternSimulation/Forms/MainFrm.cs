using BirdSim;
using MigrationPatternSimulation.Classes;
using MigrationPatternSimulation.Forms;

namespace MigrationPatternSimulation
{
    public partial class MainFrm : Form
    {
        SimulationController simulationController = new SimulationController();
        public MainFrm()
        {
            InitializeComponent();
            listBox_Agents.BindingContext = new BindingContext();
            //listBox_Agents.DataSource = simulationController.getAgentsList();
            listBox_Agents.DisplayMember = "speciesName";

            listBox_Environments.BindingContext = new BindingContext();
            //listBox_Environments.DataSource = simulationController.getEnvironments();
            listBox_Environments.DisplayMember = "instanceName";

            listBox_Experiments.BindingContext= new BindingContext();
            listBox_Experiments.DisplayMember = "experimentName";

            simulationController.setUpAgent();
            updateAgentBox();
            updateEnvironmentsBox();

        }



        private async void button_newAgent_Click(object sender, EventArgs e)
        {
            CreateAgent_Form form2 = new CreateAgent_Form(simulationController);
            form2.ShowDialog();
            updateAgentBox();
            
        }

        private void updateAgentBox()
        {
            listBox_Agents.Items.Clear();
            listBox_Agents.Items.AddRange(simulationController.getAgentsList().ToArray());
        }

        private void updateEnvironmentsBox()
        {
            listBox_Environments.Items.Clear();
            listBox_Environments.Items.AddRange(simulationController.getEnvironments().ToArray());
        }

        private void updateExperimentsBox()
        {
            listBox_Experiments.Items.Clear();
            listBox_Experiments.Items.AddRange(simulationController.getExperiments().ToArray());
        }

        private void listBox_Agents_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_Agents.SelectedItem != null)
            {
                LatitudinalAgent a = listBox_Agents.SelectedItem as LatitudinalAgent;
                if (a != null)
                {
                    DeleteOrAddRuleToAgent deleteOrAddRule = new DeleteOrAddRuleToAgent(a, ref simulationController);   
                    deleteOrAddRule.ShowDialog();
                }
            }
            updateAgentBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateEnvironmentForm createEnvironment = new CreateEnvironmentForm(ref simulationController);
            createEnvironment.ShowDialog();
            updateEnvironmentsBox();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }

        private void listBox_Environments_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_Agents.SelectedItem != null)
            {
                SimulationInstance a = listBox_Environments.SelectedItem as SimulationInstance;
                if (a != null)
                {
                    DeleteEnvironment delete = new DeleteEnvironment(ref simulationController, a);
                    delete.ShowDialog();
                }
            }
            updateEnvironmentsBox();
        }

        private void button_NewExperiment_Click(object sender, EventArgs e)
        {
            CreateExperiment createExperiment = new CreateExperiment(ref simulationController);
            createExperiment.ShowDialog();
            updateExperimentsBox();
        }

        private void listBox_Experiments_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_Experiments.SelectedItem != null)
            {
                Experiment exp = listBox_Experiments.SelectedItem as Experiment;
                if (exp != null)
                {
                    RunOrDeleteExperiment runOrDelete = new RunOrDeleteExperiment(ref simulationController, exp);
                    runOrDelete.ShowDialog();
                }
            }
            updateEnvironmentsBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompileExperimentOutputs compileExperimentOutputs = new CompileExperimentOutputs(ref simulationController, listBox_Experiments.Text);
            compileExperimentOutputs.ShowDialog();
        }

        private void button_ProduceRegression_Click(object sender, EventArgs e)
        {
            UsePythonFunctions usePythonFunctions = new UsePythonFunctions();
            usePythonFunctions.ShowDialog();
        }
    }

}