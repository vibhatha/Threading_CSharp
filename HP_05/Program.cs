using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HP5
{
    class Program
    {
        [ThreadStatic]
        public static int _field;
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(() => 
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread A : {0}",_field);

                }
            }));

            t1.Start();

            Thread t2 = new Thread(new ThreadStart(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread B : {0}", _field);

                }
            }));

            t2.Start();
        }
    }
}
