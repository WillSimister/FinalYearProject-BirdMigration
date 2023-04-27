using BirdSim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationPatternSimulation.Classes
{
    public class Climate : SimulationProperty
    {
        private int temp;

        public int getTemp()
        {
            return temp;
        }

        public void setTemp(int temp)
        {
            this.temp = temp;
        }
    }
}
