using System;
using System.Linq;

namespace Project.Euler
{
    public static class Question0004FindLargestPalindrome
    {

        public static int FindLargestPalindrome(int n)
        {
            var isFound = false;
            var firstHalf = 998;
            var palindrome = 0;
            var factors = new int[2].ToList();
            while (!isFound)
            {
                firstHalf--;
                palindrome = FindPalindrome(firstHalf);
                for (int i = 999; i > 99; i--)
                {
                    if (palindrome / i > 999 || i * i < palindrome) break;
                    if (palindrome % i == 0)
                    {
                        isFound = true;
                        factors[0] = palindrome / i;
                        factors[1] = i;
                        break;
                    }
                }
            }
            return palindrome;
        }

        public static int FindPalindrome(int firstHalf)
        {
            var reversed = firstHalf.ToString().Reverse().ToArray();
            return Convert.ToInt32(firstHalf + new string(reversed));
        }

    }
}
