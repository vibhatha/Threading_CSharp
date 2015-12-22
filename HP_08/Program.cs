using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP8
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task<int> t1 = Task.Run(() =>
            //{
            //    return 42;
            //}).ContinueWith((i) =>
            //    {
            //        return i.Result * 2;
            //    });

            //t1 = t1.ContinueWith((i) =>
            //    {
            //        return i.Result * 2;
            //    });

            //Console.WriteLine(t1.Result);


            Task<int> t1 = Task.Run(() =>
            {
               return 42;
            });

           

            t1.ContinueWith((i) => 
                {
                    Console.WriteLine("Fault");
                },TaskContinuationOptions.OnlyOnFaulted);


            t1.ContinueWith((i) =>
            {
                Console.WriteLine("Completed");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);
            Console.WriteLine(t1.Result);
        }
    }
}
 