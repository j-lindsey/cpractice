using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPalindrome
{
    class Program
    {
        public static bool IsPalindrome(int x)
        {
            List<int> digits = new List<int>();
            if (x < 0) return false;
            int n = x;
            for (; n != 0; n /= 10)
                digits.Add(n % 10);

            int reversedInt = 0;
            for (int i = 0; i < digits.Count; i++) {
                reversedInt = 10 * reversedInt + digits[i] ;
            }

            if (reversedInt == x)
            {
                return true;
            }
            else {
                return false;
            }
        }
        static void Main(string[] args)
        {   
            int x = 121;
            bool valid = IsPalindrome(x);
            Console.WriteLine(x + " " + valid);
            x = -121;
            valid = IsPalindrome(x);
            Console.WriteLine(x + " " + valid);
            x = 10;
            valid = IsPalindrome(x);
            Console.WriteLine(x + " " + valid);
            x = -101;
            valid = IsPalindrome(x);
            Console.WriteLine(x + " " + valid);
            Console.ReadLine();
        }
    }
}
