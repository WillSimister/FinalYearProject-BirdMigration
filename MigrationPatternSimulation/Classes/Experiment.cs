using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using BirdSim;

namespace MigrationPatternSimulation.Classes
{
    public class Experiment
    {
        private SimulationController simulationController;
        private SimulationInstance environment;
        private Agent agent;
        private ExperimentLogger logger;
        TimeController timeController;

        public string experimentName { get; set; }
        public string experimentDescription { get; set; }

        public Experiment(SimulationInstance instance, Agent _agent, string expName, string expDesc, SimulationController controller)
        {
            environment = instance;
            agent = _agent;
            experimentName = expName;
            experimentDescription = expDesc;
            simulationController = controller;
            logger = new ExperimentLogger(this);
        }


        public void runExperiment()
        {
            LatitudinalAgent latAgent;
            if (agent.GetType() == typeof(LatitudinalAgent))
            {
                latAgent = (LatitudinalAgent)agent;
            }
            else
            {
                //In future development this will be a larger if statement allowing for many different types of Migrant Agents.
                latAgent = new LatitudinalAgent();
            }

            //So we get a time controller - set month to 0;
            timeController = new TimeController(true);
            bool hasMigratedNorth = false;
            bool hasMigratedSouth = false;
            //Check is it Agents normal northern migration month
            if (latAgent != null)
            {
                while (timeController.getOneYear() == true)
                {
                    foreach (Rule rule in latAgent.getRules())
                    {
                        if (rule.getRuleType() == ruleTypeEnum.Month)
                        {
                            checkMonthRules(ref hasMigratedNorth, ref hasMigratedSouth, ref latAgent, rule, timeController);
                        }
                        if (rule.getRuleType() == ruleTypeEnum.ClimateTemp)
                        {
                            checkClimateTempRule(ref hasMigratedNorth, ref hasMigratedSouth, ref latAgent, rule, timeController);
                        }
                    }
                    timeController.progressTime();
                }
            }
            //Check if any rules are being hit

        }


        private void checkMonthRules(ref bool hasMigratedN, ref bool hasMigratedS, ref LatitudinalAgent latAgent, Rule rule, TimeController timeController)
        {
            if (rule.getGreaterThan() == true)
            {
                if (timeController.getSimulationController().getMonth() > rule.getRuleParameter())
                {
                    makeDecision(ref latAgent, rule, ref hasMigratedN, ref hasMigratedS);
                }
            }
            if (rule.getLessThan() == true)
            {
                if (timeController.getSimulationController().getMonth() < rule.getRuleParameter())
                {
                    makeDecision(ref latAgent, rule, ref hasMigratedN, ref hasMigratedS);
                }
            }
            if (rule.getEqualTo() == true)
            {
                if (timeController.getSimulationController().getMonth() == rule.getRuleParameter())
                {
                    makeDecision(ref latAgent, rule, ref hasMigratedN, ref hasMigratedS);
                }
            }
        }

        private void checkClimateTempRule(ref bool hasMigratedN, ref bool hasMigratedS, ref LatitudinalAgent latAgent, Rule rule, TimeController timeController)
        {
            if (rule.getGreaterThan() == true)
            {
                if (environment.Countries.FirstOrDefault()
                    .getClimateData()
                    .GetValueOrDefault(timeController.getSimulationController().getMonth()) > rule.getRuleParameter())
                {
                    makeDecision(ref latAgent, rule, ref hasMigratedS, ref hasMigratedS);
                }
            }
            if (rule.getLessThan() == true)
            {
                if (environment.Countries.FirstOrDefault()
                    .getClimateData()
                    .GetValueOrDefault(timeController.getSimulationController().getMonth()) < rule.getRuleParameter())
                {
                    makeDecision(ref latAgent, rule, ref hasMigratedN, ref hasMigratedS);
                }
            }
            if (rule.getEqualTo() == true)
            {
                if (environment.Countries.FirstOrDefault()
                    .getClimateData()
                    .GetValueOrDefault(timeController.getSimulationController().getMonth()) == rule.getRuleParameter())
                {
                    makeDecision(ref latAgent, rule, ref hasMigratedN, ref hasMigratedS);
                }
            }
        }


        private void makeDecision(ref LatitudinalAgent latAgent, Rule rule, ref bool hasMigratedN, ref bool hasMigratedS)
        {
            if (rule.getAction() == ActionEnum.migrateNorth)
            {
                if (hasMigratedN)
                {
                    Country nextClosestNorthernCountry = simulationController.getCountryFromCountryCode(latAgent.getNormalNorthernCountry().getClosestNorthern());
                    nextClosestNorthernCountry.setClimateData(latAgent.getNormalNorthernCountry().getClimateData());
                    latAgent.setCurrentLocation(nextClosestNorthernCountry);
                    
                    //Log Migration
                    logger.addNewLineToLog($"breeding migration, {latAgent.getName()}, {latAgent.getNormalNorthernCountry().getName()}, {latAgent.getNormalNorthernMigrationMonth()},{latAgent.getCurrentLocation().getName()},{timeController.getSimulationController().getMonth()}, {latAgent.getCurrentLocation().getClimateData().GetValueOrDefault(timeController.getSimulationController().getMonth())}");
                }
                else
                {
                    latAgent.setCurrentLocation(latAgent.getNormalNorthernCountry());
                    //Log Migration
                    Country nextClosestNorthernCountry = simulationController.getCountryFromCountryCode(latAgent.getNormalNorthernCountry().getClosestNorthern());
                    nextClosestNorthernCountry.setClimateData(latAgent.getNormalNorthernCountry().getClimateData());
                    logger.addNewLineToLog($"breeding migration, {latAgent.getName()}, {latAgent.getNormalNorthernCountry().getName()}, {latAgent.getNormalNorthernMigrationMonth()},{latAgent.getCurrentLocation().getName()},{timeController.getSimulationController().getMonth()}, {latAgent.getCurrentLocation().getClimateData().GetValueOrDefault(timeController.getSimulationController().getMonth())}");
                    hasMigratedN = true;
                }
            }
            else if (rule.getAction() == ActionEnum.migrateSouth)
            {
                if (hasMigratedS)
                {
                    Country nextClosestSouthernCountry = simulationController.getCountryFromCountryCode(latAgent.getNormalSouthernCountry().getClosestSouthern());
                    nextClosestSouthernCountry.setClimateData(latAgent.getNormalSouthernCountry().getClimateData());
                    latAgent.setCurrentLocation(nextClosestSouthernCountry);
                    
                    logger.addNewLineToLog($"nesting migration, {latAgent.getName()}, {latAgent.getNormalSouthernCountry().getName()}, {latAgent.getNormalSouthernMigrationMonth()},{latAgent.getCurrentLocation().getName()},{timeController.getSimulationController().getMonth()}, {latAgent.getCurrentLocation().getClimateData().GetValueOrDefault(timeController.getSimulationController().getMonth())}");

                }
                else
                {
                    //log Migration
                    latAgent.setCurrentLocation(latAgent.getNormalSouthernCountry());
                    logger.addNewLineToLog($"nesting migration, {latAgent.getName()}, {latAgent.getNormalSouthernCountry().getName()}, {latAgent.getNormalSouthernMigrationMonth()},{latAgent.getCurrentLocation().getName()},{timeController.getSimulationController().getMonth()}, {latAgent.getCurrentLocation().getClimateData().GetValueOrDefault(timeController.getSimulationController().getMonth())}");
                    hasMigratedS = true;

                }
            }
        }

        //private bool isWithinMinMaxForLocation(bool northSouth, LatitudinalAgent agent) //True = north, False = south
        //{
        //    if(northSouth == true)
        //    {
        //        environment.
        //    }
        //}


        public string getName()
        {
            return experimentName;
        }



    }
}
