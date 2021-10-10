using System;
using System.Collections;

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
        }
    }
}
