using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HP_11
{
    class Program
    {
        //parallel class
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //    Thread.Sleep(1000);
            //}
            Thread.Sleep(2000);
            Console.WriteLine("Start");

            Parallel.For(0, 10, (i) => 
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                });

            Console.WriteLine("For Each");

            int[] myArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //foreach (int i in myArray)
            //{
            //    Console.WriteLine(i);
            //    Thread.Sleep(1000);
            //}


            Parallel.ForEach(myArray, (i) =>
                {
                Console.WriteLine(i);
                Thread.Sleep(1000);

                });


            
        }
    }
}
