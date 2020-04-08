using System;
using System.Threading;

namespace ConsoleApp1
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello World!");
    //    }
    //}

    public delegate string MyDel(string str);
    public class EventProgram
    {
    static void Main(string[] args)
        {
            var p = new NrPrim();
            NrPrim.x = 10;
            Thread a = new Thread(p.firstPrimeM1);
            Thread b = new Thread(p.firstPrimeM2);

            a.Start();
            b.Start();
        }
    }

    public class NrPrim{
        public static int x;
        public bool isPrim(int n)
        {
            int d = 2;
            while(d<n)
            {
                if (n % d == 0)
                {
                    return false;
                }
                d++;
            }

            return false ;
        }

        public void firstPrimeM1()
        {
            int test = 2;
            int last = 0;
            while(test < x)
            {
                if(isPrim(test) == true)
                {
                    last = test;
                }

                test++;
            }

            Console.WriteLine(last);
        }

        public void firstPrimeM2()
        {
            int test = x - 1;
            while(test > 1)
            {
                if(isPrim(test) ==true)
                {
                    Console.WriteLine(test);
                    break;
                }
                test++;
            }
        }
		
		public delegate string BuildText(string text);
        class MyEvent {

            event BuildText currentEvent;
            MyEvent()
            {

            }

        }
    }
}
