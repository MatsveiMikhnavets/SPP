using System;

namespace spp_lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            var logBuffer = new LogBuffer("C:\\Users\\User\\Desktop\\1\\spp-lab6-master\\spp-lab6\\test.txt");
            for (var i = 1; i <= 100; i++)
            {
                logBuffer.Add(i.ToString());
            }
            Console.WriteLine("Press the Enter key to exit ... ");
            Console.ReadLine();
            logBuffer.Close();
        }
    }
}