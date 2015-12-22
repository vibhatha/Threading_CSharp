using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HP4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stopped = false;
            Thread t = new Thread(new ThreadStart(() => 
                {

                    while (!stopped) 
                    {
                        Console.WriteLine("Running");
                        Thread.Sleep(1000);
                    }

                    Console.WriteLine("Thread is about to close");
            
            
                }));

            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            Console.WriteLine("");
            stopped = true;
            t.Join();

        }
    }
}
