using System.Text;

namespace MigrationPatternSimulation.Classes
{
    internal class MachineLearningDataCompiler
    {
        public string chosenFileName { get; set; }
        public string directory { get; set; }

        public string ExperimentFile { get; set; }
        public string fileYear { get; set; }

        public MachineLearningDataCompiler(string chosenfileName, string fileYear)
        {
            this.chosenFileName = chosenfileName;
            this.fileYear = fileYear;
        }

        public void compileMLDataset()
        {
            ///Create text file with the log
            string fileName = @$"C:\MLExperimentFiles\{chosenFileName}.txt";

            try
            {
                // Check if file already exists. If yes, change name.    
                if (File.Exists(fileName))
                {
                    char last = chosenFileName.LastOrDefault();
                    if (int.TryParse(last.ToString(), out int res))
                    {
                        string newExperimentName = chosenFileName + (last + 1);
                        chosenFileName = newExperimentName;
                    }
                    else
                    {
                        chosenFileName = chosenFileName + 1;
                    }
                    fileName = @$"C:\ExperimentLogs\{chosenFileName}.txt";
                }
                ExperimentFile = fileName;
                FileInfo file = new FileInfo(fileName);

                // Create a new file     
                using (FileStream fs = File.Create(fileName))
                {
 
                }

                fileName = file.Name.Remove(file.Name.Length - 4);

            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }

            //FileInfo file = new FileInfo(ExperimentFile);
            compileExperiments(fileName);

            string csvfilePath = $@"C:\MLExperimentFiles\{fileName}CSV.csv";
            string[] lines = System.IO.File.ReadAllLines(ExperimentFile);

            File.WriteAllLines(csvfilePath, lines);

        }

        private void compileExperiments(string nameOfFile)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\ExperimentLogs");

            FileInfo[] experimentFiles = d.GetFiles("*.txt");
            List<FileInfo> experimentsFilesContainingName = new List<FileInfo>();

            foreach (FileInfo experimentFile in experimentFiles)
            {
                if (experimentFile.Name.Contains(nameOfFile))
                {
                    experimentsFilesContainingName.Add(experimentFile);
                }
            }
            
            foreach(FileInfo experimentFile in experimentsFilesContainingName)
            {
                string fileName = experimentFile.FullName;
                string fileYear = experimentFile.Name.Remove(experimentFile.Name.Length - 4, 4);
                List<string> lines = new List<string>();

                using (var fileStream = File.OpenRead(fileName))
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 1024))
                {
                    bool firstLine = true;
                    String line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        // Process line
                        if (firstLine != true)
                        {
                            lines.Add(processLine(line, fileYear));
                        }
                        else
                        {
                            firstLine = false;
                        }
                    }
                }

                using(StreamWriter writer = new StreamWriter(ExperimentFile, append: true))
                {
                    foreach(string line in lines)
                    {
                        writer.WriteLine(line);
                    }
                }
            }

        }

        private string processLine(string line, string year)
        {
            string newLine = "";
            newLine = newLine + fileYear;

            string[] values = line.Split(',');
            //Year,MigrationType,CountryMigrated To, Month Migrated, Current Temperature
            newLine = newLine + $",{values[5].Trim()},{values[6].Trim()},{values[1].Trim()},{values[0].Trim().Replace(" ", "-")},{values[4].Trim().Replace(" ", "-")}";

            return newLine;
        }

        

    }
}
