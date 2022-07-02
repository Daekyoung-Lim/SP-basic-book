using System;
using System.Threading;

namespace ExternProgram
{
    class Echo
    {
        public void worker()
        {
            while (true)
            {
                string line = Console.ReadLine();
                Console.WriteLine("[Echo]" + line);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            if (args[0] != null)
            {
                Console.WriteLine("[Echo]{0}", args[0]);
            }

            Echo echo = new Echo();

            Thread th = new Thread(echo.worker);

            th.Start();
            th.Join();
        }
    }
}
