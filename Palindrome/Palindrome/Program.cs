using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        public static bool IsPalindrome(string text)
        {
            var content = text.ToCharArray();
            int length = content.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (content[i] != content[length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            bool isTrue = IsPalindrome("thisisacat");
            bool isTrue2 = IsPalindrome("racecar");
        }
    }
}
