using System;
using System.Diagnostics;
using System.Threading;

namespace bandymas
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Thread.Sleep(1000);
            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;

            Console.WriteLine("Elapsed Time is {0:00}:{1:00}:{2:00}.{3}",
                            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine("-----------------------");

            //kuriamas objektas
            matematika obj = new matematika();
            obj.progresija();

            Console.WriteLine("Reikia elementu: " + obj.n);
            Console.WriteLine("Galutinis atsakymas: " + obj.ats);

            Console.ReadLine();
        }
    }
}