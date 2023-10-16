using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FrmBasicThread1
{
    internal class MyTHreadClass
    {
        public static void Thread1()
        {
            for (int Loopcount = 0; Loopcount <=5; Loopcount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: "+ thread.Name+ " = "+Loopcount );
                Thread.Sleep(1500);
            }
        }
    }
}
