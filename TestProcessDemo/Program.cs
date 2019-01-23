using System;
using System.Diagnostics;
using System.Linq;

namespace TestProcessDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            queryProcess();
            Console.WriteLine("Hello World!");
        }

        static void startProcess()
        {
            Process process = Process.Start(
                new ProcessStartInfo
                {
                    FileName = "/bin/bash",
                    Arguments = $"-c \"{""}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
                );
            string result = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            Console.WriteLine();
        }

        static void queryProcess()
        {
            var process = Process.GetProcesses();
            process.ToList().ForEach(p => {
                Console.WriteLine("pNm:" + p.ProcessName);
            });
            Console.WriteLine(process.Count());
        }
    }
}
