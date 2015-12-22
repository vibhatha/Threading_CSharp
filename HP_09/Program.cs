﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HP9
{
    class Program
    {
        //wait-all
        static void Main(string[] args)
        {
            Task[] tasks = new Task[3];

            tasks[0] = Task.Run(() => 
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(1);
                    return 1;
                });

            tasks[1] = Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine(2);
                return 2;
            });


            tasks[2] = Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine(3);
                return 3;
            });
            
            //tasks[1].Wait(); //wait until the task0 is completed.
            //but if the delays are equal this is not going to happen.

            //waiting for all tasks to be completed, not considering the time

            Task.WaitAll(tasks);


        }
    }
}
