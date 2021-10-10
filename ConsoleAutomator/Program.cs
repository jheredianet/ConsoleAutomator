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

            var command = "/";
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "find",/// @"C:\Windows\System32\cmd.exe",
                    Arguments = command,
                    RedirectStandardInput = false,
                    RedirectStandardError = false,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = false
                }
            };
            proc.Start();
        }
    }
}
