using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace spp_lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcessesByName("notepad++");

            foreach (Process process in processes)
            {
                Console.WriteLine($"Handle: {process.Handle} Id: {process.Id} Name: {process.ProcessName}");
                OSHandle osHandle = new OSHandle(process.Handle);
            }
            
        }
    }
}