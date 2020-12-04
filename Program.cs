using System;
using System.Threading;
namespace ThreadingSyntax
{
    class Program
    {
       static public Thread oThread = new Thread(MethodJoin);
        static public Thread oThread1 = new Thread(MethodJoin1);
        static void Main(string[] args)
        {
            oThread.Start();
            oThread.Join();
            oThread1.Start();
            oThread1.Join();
           // oThread1.Join();
            Console.WriteLine("work completed..!");
            

        }
    

            static void MethodJoin()
            {
                for (int i = 0; i <= 100; i++)
                {
                    Console.WriteLine("work is in progress..1");
                  

                }
            Monitor.Wait(oThread);



        }
            static void MethodJoin1()
            {
                Monitor.Pulse(oThread);
                for (int i = 0; i <= 100; i++)
                {
                    Console.WriteLine("work is in progress..2");

                }


            }
        


    }
}
