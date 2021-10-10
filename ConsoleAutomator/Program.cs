using System;
using System.Collections;
using System.Diagnostics;

namespace ConsoleAutomator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data from Server Environmet:");
            Console.WriteLine();
            Console.WriteLine("GetEnvironmentVariables: ");
            foreach (DictionaryEntry de in Environment.GetEnvironmentVariables())
                Console.WriteLine("  {0} = {1}", de.Key, de.Value);

            var command = "/var/jenkins_home/";
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "find",/// @"C:\Windows\System32\cmd.exe",
                    Arguments = command,
                    RedirectStandardInput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.EnableRaisingEvents = true;
            proc.OutputDataReceived += (s, e) => Debug.WriteLine(e.Data);
            proc.ErrorDataReceived += (s, e) => Debug.WriteLine($@"Error: {e.Data}");
            proc.Start();
            proc.BeginOutputReadLine();
            proc.BeginErrorReadLine();
            proc.WaitForExit();



        }
    }
}
