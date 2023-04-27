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
    public partial class DeleteRule_Form : Form
    {
        LatitudinalAgent agent;
        BirdSim.Rule rule;
        public DeleteRule_Form(ref LatitudinalAgent agent, BirdSim.Rule rule)
        {
            InitializeComponent();
            this.agent = agent;
            this.rule = rule;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            agent.deleteRule(rule);
            this.Close();
        }
    }
}
