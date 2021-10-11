using System;
using System.Collections;
using System.Diagnostics;

namespace ConsoleAutomator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Environment.GetCommandLineArgs().Length != 3)
            {
                Console.WriteLine("Use this program with 2 parameters: FileName and Arguments");
                return;
            }

            var FileName = Environment.GetCommandLineArgs()[1];
            var Arguments = Environment.GetCommandLineArgs()[2];


            Console.WriteLine("Data from Server Environmet:");
            Console.WriteLine();
            Console.WriteLine("GetEnvironmentVariables: ");
            foreach (DictionaryEntry de in Environment.GetEnvironmentVariables())
                Console.WriteLine("  {0} = {1}", de.Key, de.Value);

            var process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = FileName,
                    Arguments = Arguments
                    //RedirectStandardOutput = true,
                    //UseShellExecute = false,
                    //CreateNoWindow = true,
                }
            };

            process.Start();
            process.WaitForExit();



        }
    }
}
