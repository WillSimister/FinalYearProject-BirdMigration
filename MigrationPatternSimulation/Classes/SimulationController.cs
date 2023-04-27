﻿using MigrationPatternSimulation.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace BirdSim
{
    public class SimulationController
    {
        private TimeController timeController;

        Dictionary<string, string> countries = new Dictionary<string, string>()
    {
        {"Afghanistan", "AF"},
        {"Albania", "AL"},
        {"Algeria", "DZ"},
        {"American Samoa", "AS"},
        {"Andorra", "AD"},
        {"Angola", "AO"},
        {"Anguilla", "AI"},
        {"Antarctica", "AQ"},
        {"Antigua and Barbuda", "AG"},
        {"Argentina", "AR"},
        {"Armenia", "AM"},
        {"Aruba", "AW"},
        {"Australia", "AU"},
        {"Austria", "AT"},
        {"Azerbaijan", "AZ"},
        {"Bahamas", "BS"},
        {"Bahrain", "BH"},
        {"Bangladesh", "BD"},
        {"Barbados", "BB"},
        {"Belarus", "BY"},
        {"Belgium", "BE"},
        {"Belize", "BZ"},
        {"Benin", "BJ"},
        {"Bermuda", "BM"},
        {"Bhutan", "BT"},
        {"Bolivia", "BO"},
        {"Bosnia and Herzegovina", "BA"},
        {"Botswana", "BW"},
        {"Bouvet Island", "BV"},
        {"Brazil", "BR"},
        {"British Indian Ocean Territory", "IO"},
        {"Brunei Darussalam", "BN"},
        {"Bulgaria", "BG"},
        {"Burkina Faso", "BF"},
        {"Burundi", "BI"},
        {"Cambodia", "KH"},
        {"Cameroon", "CM"},
        {"Canada", "CA"},
        {"Cape Verde", "CV"},
        {"Cayman Islands", "KY"},
        {"Central African Republic", "CF"},
        {"Chad", "TD"},
        {"Chile", "CL"},
        {"China", "CN"},
        {"Christmas Island", "CX"},
        {"Cocos (Keeling) Islands", "CC"},
        {"Colombia", "CO"},
        {"Comoros", "KM"},
        {"Congo", "CG"},
        {"Congo, The Democratic Republic of The", "CD"},
        {"Cook Islands", "CK"},
        {"Costa Rica", "CR"},
        {"Cote D'ivoire", "CI"},
        {"Croatia", "HR"},
        {"Cuba", "CU"},
        {"Cyprus", "CY"},
        {"Czech Republic", "CZ"},
        {"Denmark", "DK"},
        {"Djibouti", "DJ"},
        {"Dominica", "DM"},
        {"Dominican Republic", "DO"},
        {"Ecuador", "EC"},
        {"Egypt", "EG"},
        {"El Salvador", "SV"},
        {"Equatorial Guinea", "GQ"},
        {"Eritrea", "ER"},
        {"Estonia", "EE"},
        {"Ethiopia", "ET"},
        {"Falkland Islands (Malvinas)", "FK"},
        {"Faroe Islands", "FO"},
        {"Fiji", "FJ"},
        {"Finland", "FI"},
        {"France", "FR"},
        {"French Guiana", "GF"},
        {"French Polynesia", "PF"},
        {"French Southern Territories", "TF"},
        {"Gabon", "GA"},
        {"Gambia", "GM"},
        {"Georgia", "GE"},
        {"Germany", "DE"},
        {"Ghana", "GH"},
        {"Gibraltar", "GI"},
        {"Greece", "GR"},
        {"Greenland", "GL"},
        {"Grenada", "GD"},
        {"Guadeloupe", "GP"},
        {"Guam", "GU"},
        {"Guatemala", "GT"},
        {"Guinea", "GN"},
        {"Guinea-bissau", "GW"},
        {"Guyana", "GY"},
        {"Haiti", "HT"},
        {"Heard Island and Mcdonald Islands", "HM"},
        {"Holy See (Vatican City State)", "VA"},
        {"Honduras", "HN"},
        {"Hong Kong", "HK"},
        {"Hungary", "HU"},
        {"Iceland", "IS"},
        {"India", "IN"},
        {"Indonesia", "ID"},
        {"Iran, Islamic Republic of", "IR"},
        {"Iraq", "IQ"},
        {"Ireland", "IE"},
        {"Israel", "IL"},
        {"Italy", "IT"},
        {"Jamaica", "JM"},
        {"Japan", "JP"},
        {"Jordan", "JO"},
        {"Kazakhstan", "KZ"},
        {"Kenya", "KE"},
        {"Kiribati", "KI"},
        {"Korea, Democratic People's Republic of", "KP"},
        {"Korea, Republic of", "KR"},
        {"Kuwait", "KW"},
        {"Kyrgyzstan", "KG"},
        {"Lao People's Democratic Republic", "LA"},
        {"Latvia", "LV"},
        {"Lebanon", "LB"},
        {"Lesotho", "LS"},
        {"Liberia", "LR"},
        {"Libyan Arab Jamahiriya", "LY"},
        {"Liechtenstein", "LI"},
        {"Lithuania", "LT"},
        {"Luxembourg", "LU"},
        {"Macao", "MO"},
        {"North Macedonia", "MK"},
        {"Madagascar", "MG"},
        {"Malawi", "MW"},
        {"Malaysia", "MY"},
        {"Maldives", "MV"},
        {"Mali", "ML"},
        {"Malta", "MT"},
        {"Marshall Islands", "MH"},
        {"Martinique", "MQ"},
        {"Mauritania", "MR"},
        {"Mauritius", "MU"},
        {"Mayotte", "YT"},
        {"Mexico", "MX"},
        {"Micronesia, Federated States of", "FM"},
        {"Moldova, Republic of", "MD"},
        {"Monaco", "MC"},
        {"Mongolia", "MN"},
        {"Montserrat", "MS"},
        {"Morocco", "MA"},
        {"Mozambique", "MZ"},
        {"Myanmar", "MM"},
        {"Namibia", "NA"},
        {"Nauru", "NR"},
        {"Nepal", "NP"},
        {"Netherlands", "NL"},
        {"Netherlands Antilles", "AN"},
        {"New Caledonia", "NC"},
        {"New Zealand", "NZ"},
        {"Nicaragua", "NI"},
        {"Niger", "NE"},
        {"Nigeria", "NG"},
        {"Niue", "NU"},
        {"Norfolk Island", "NF"},
        {"Northern Mariana Islands", "MP"},
        {"Norway", "NO"},
        {"Oman", "OM"},
        {"Pakistan", "PK"},
        {"Palau", "PW"},
        {"Palestine", "PS"},
        {"Panama", "PA"},
        { "Papua New Guinea", "PG" },
        { "Paraguay", "PY" },
        { "Peru", "PE" },
        { "Philippines", "PH" },
        { "Pitcairn", "PN" },
        { "Poland", "PL" },
        { "Portugal", "PT" },
        { "Puerto Rico", "PR" },
        { "Qatar", "QA" },
        { "Reunion", "RE" },
        { "Romania", "RO" },
        { "Russian Federation", "RU" },
        { "Rwanda", "RW" },
        { "Saint Helena", "SH" },
        { "Saint Kitts and Nevis", "KN" },
        { "Saint Lucia", "LC" },
        { "Saint Pierre and Miquelon", "PM" },
        { "Saint Vincent and The Grenadines", "VC" },
        { "Samoa", "WS" },
        { "San Marino", "SM" },
        { "Sao Tome and Principe", "ST" },
        { "Saudi Arabia", "SA" },
        { "Senegal", "SN" },
        { "Serbia and Montenegro", "CS" },
        { "Seychelles", "SC" },
        { "Sierra Leone", "SL" },
        { "Singapore", "SG" },
        { "Slovakia", "SK" },
        { "Slovenia", "SI" },
        { "Solomon Islands", "SB" },
        { "Somalia", "SO" },
        { "South Africa", "ZA" },
        { "South Georgia and The South Sandwich Islands", "GS" },
        { "Spain", "ES" },
        { "Sri Lanka", "LK" },
        { "Sudan", "SD" },
        { "Suriname", "SR" },
        { "Svalbard and Jan Mayen", "SJ" },
        { "Swaziland", "SZ" },
        { "Sweden", "SE" },
        { "Switzerland", "CH" },
        { "Syrian Arab Republic", "SY" },
        { "Taiwan, Province of China", "TW" },
        { "Tajikistan", "TJ" },
        { "Tanzania, United Republic of", "TZ" },
        { "Thailand", "TH" },
        { "Timor-leste", "TL" },
        { "Togo", "TG" },
        { "Tokelau", "TK" },
        { "Tonga", "TO" },
        { "Trinidad and Tobago", "TT" },
        { "Tunisia", "TN" },
        { "Turkey", "TR" },
        { "Turkmenistan", "TM" },
        { "Turks and Caicos Islands", "TC" },
        { "Tuvalu", "TV" },
        { "Uganda", "UG" },
        { "Ukraine", "UA" },
        { "United Arab Emirates", "AE" },
        { "United Kingdom", "GB" },
        { "United States", "US" },
        { "United States Minor Outlying Islands", "UM" },
        { "Uruguay", "UY" },
        { "Uzbekistan", "UZ" },
        { "Vanuatu", "VU" },
        { "Venezuela", "VE" },
        { "Viet Nam", "VN" },
        { "Virgin Islands, British", "VG" },
        { "Virgin Islands, U.S.", "VI" },
        { "Wallis and Futuna", "WF" },
        { "Western Sahara", "EH" },
        { "Yemen", "YE" },
        { "Zambia", "ZM" },
        { "Zimbabwe", "ZW" }
    };

        public List<Country> countryObjects = new List<Country>();
        public List<LatitudinalAgent> agents = new List<LatitudinalAgent>();
        List<SimulationInstance> environments = new List<SimulationInstance>();
        List<Experiment> experiments = new List<Experiment>();


        public SimulationController()
        {
            setupCountries();
            timeController = new TimeController();

        }

        //A second Constructor to allow us to create an instance of
        //SimulationController that in essence is Headless for running tests
        public SimulationController(bool isFromTests)
        {
            setupCountries();
        }

        void setupCountries()
        {
            foreach (var country in countries)
            {
                Country newCountry = new Country(country.Key, country.Value);
                countryObjects.Add(newCountry);
            }
        }

        public void setUpAgent()
        {
            Rule rule = new Rule("Migrate North in June", ruleTypeEnum.Month, false, false, true, false, false, 6, ActionEnum.migrateNorth);
            Rule rule2 = new Rule("Migrate South in September", ruleTypeEnum.Month, false, false, true, false, false, 9, ActionEnum.migrateSouth);
            ClimateDataParser parser = new ClimateDataParser();
            LatitudinalAgent agent = new LatitudinalAgent("Golden Plover", 9, 6, countryObjects.Where(x => x.name == "Canada").FirstOrDefault(), countryObjects.Where(x => x.name == "Argentina").FirstOrDefault(), countryObjects.Where(x => x.name == "Argentina").FirstOrDefault());
            agent.addRule(rule);
            agent.addRule(rule2);
            countryObjects.Where(x => x.name == "Canada").FirstOrDefault().setClosestCountries("RU", "PT", "US", "JP");
            countryObjects.Where(x => x.name == "Canada").FirstOrDefault().setClimateData(parser.getNorthernPlover());
            countryObjects.Where(x => x.name == "Argentina").FirstOrDefault().setClosestCountries("UY", "PY", "UY", "PY");
            countryObjects.Where(x => x.name == "Argentina").FirstOrDefault().setClimateData(parser.getSouthernPlover());
            List<Country> countries = new List<Country>()
            {
                countryObjects.Where(x => x.name == "Canada").FirstOrDefault(),
                countryObjects.Where(x => x.name == "Argentina").FirstOrDefault()

            };

            SimulationInstance instance = new SimulationInstance(countries, "Natural Environment For Plover-2023");

            addEnvironment(instance);
            addAgentToAgentsList(agent);
        }

        void setCurrentTemp()
        {
            using (var reader = new StreamReader(@"C:\test.csv"))
            {
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    listA.Add(values[0]);
                    listB.Add(values[1]);
                }
            }
        }

        public List<LatitudinalAgent> getAgentsList()
        {
            return agents;
        }

        public Country getCountryFromCountryCode(string value)
        {
            foreach (Country country in countryObjects)
            {
                if (country.getCode() == value)
                {
                    return country;
                }
            }

            return null;
        }

        public string getCountryNameFromCountryCode(string Value)
        {
            return countries.FirstOrDefault(x => x.Value == Value).Key;
        }

        public void addAgentToAgentsList(LatitudinalAgent agent)
        {
            agents.Add(agent);
        }

        public void deleteAgent(LatitudinalAgent agent)
        {
            agents.Remove(agent);
        }

        public void addEnvironment(SimulationInstance instance)
        {
            environments.Add(instance);
        }

        public List<SimulationInstance> getEnvironments() { return environments; }

        public void addExperimentToList(Experiment experiment)
        {
            experiments.Add(experiment);
        }

        public List<Experiment> getExperiments()
        {
            return experiments;
        }

        public void setAgentRule(int agentIndex, Rule rule)
        {
            agents[agentIndex].addRule(rule);
        }

        public void saveAllData()
        {
            //Not Implemented
        }

        public void saveEnvironments()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(environments.First(), options);
        }

        public List<Country> getAllCountries()
        {
            return countryObjects;
        }

        public void deleteEnvironment(SimulationInstance instance)
        {
            environments.Remove(instance);
        }

        public void deleteExperiment(Experiment experiment)
        {
            experiments.Remove(experiment);
        }
    }
}