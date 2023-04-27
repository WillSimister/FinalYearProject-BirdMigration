using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationPatternSimulation.Classes
{
    internal class PythonService
    {
        string arg;
        string dataSetPath;
        string scriptToExecute;
        string pathToPython;
        string? alg;

        public PythonService(string dataSetPath, string pathToPython, string scriptToExecute, string? alg) 
        {
            this.dataSetPath = dataSetPath;
            this.scriptToExecute = scriptToExecute;
            this.pathToPython = pathToPython;
            this.alg = alg;
        }

        public PythonService(string dataSetPath, string pathToPython, string scriptToExecute)
        {
            this.dataSetPath = dataSetPath;
            this.scriptToExecute = scriptToExecute;
            this.pathToPython = pathToPython;
        }

        public void runPythonProcess()
        {
            if (alg == null)
            {
                arg = string.Format(@$"{pathToPython}\{scriptToExecute} {0}", dataSetPath);
            }
            else
            {
                arg = string.Format(@$"{pathToPython}\{scriptToExecute} {0} {1}", dataSetPath, alg);
            }

            string pythonScriptPath = pathToPython + @"\" + scriptToExecute;

            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput= true;
                process.StartInfo.RedirectStandardError= true;
                process.StartInfo.Arguments = arg;
                process.StartInfo.WorkingDirectory = @"C:\Users\willi";
                process.Start();

                process.StandardInput.WriteLine($@"python {scriptToExecute}");
                process.WaitForExit();

            }
            catch (Exception ex)
            {
                Console.WriteLine("There is a problem in the Python code: " + ex.Message);
            }
        }
    }
}
