using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Project.Euler
{
    public static class Question0037SumOfTruncatablePrimes
    {

        public static int SumOfTruncatablePrimes()
        {
            var count = 0;
            var i = 9;
            var sum = 0;
            do
            {
                i += 2;
                if (!IsPrimeNumber(i)) continue;
                if (!IsTruncatablePrime(i)) continue;
                count++;
                sum += i;
            } while (count < 11);
            return sum;
        }

        public static bool IsPrimeNumber(int n)
        {
            for (int i = 2; i < n; i++)
                if (n%i == 0) return false;
            return true;
        }

        public static bool IsTruncatablePrime(int n)
        {
            var temp = n.ToString();
            for (int i = 0; i < temp.Length; i++)
            {
                if (!IsPrimeNumber(int.Parse(temp.Substring(i)))) return false;
                if (i == 0) continue;
                if (!IsPrimeNumber(int.Parse(temp.Substring(0, i)))) return false;
            }
            return true;
        }

    }
}
