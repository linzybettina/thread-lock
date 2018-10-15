using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
     static  bool done;

        static void Main()
        {
            new Thread (Go).Start();
            Go();
            Console.ReadLine();
         }
        static void Go()
        {
            if (!done)
            {
                Console.WriteLine("Done");
                done = true;
            }

        }
    }
    }

