using System;
using System.Diagnostics;
 
namespace Project.Euler
{
    class ProjectEuler
    {

        static void Main(string[] args)
        {

            var stopwatch = Stopwatch.StartNew();
            Question0037SumOfTruncatablePrimes.SumOfTruncatablePrimes();
            Console.WriteLine(stopwatch.ElapsedMilliseconds + " milliseconds taken for this operation.");
            Console.Read();

        }


    }

}

