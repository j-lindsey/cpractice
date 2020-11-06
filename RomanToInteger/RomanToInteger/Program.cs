using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
    class Program
    {
        public static int RomanToInt(string s)
        {
            char[] num = s.ToCharArray();
            int result = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == 'M')
                {
                    result += 1000;
                }
                else if (num[i] == 'D') {
                    result += 500;
                }
                else if (num[i] == 'C')
                {
                    if (i < num.Length-1)
                    {
                        if (num[i + 1].Equals('D'))
                        {
                            result += 400;
                            i++;
                        }
                        else if (num[i + 1].Equals('M'))
                        {
                            result += 900;
                            i++;
                        }
                        else
                        {
                            result += 100;
                        }
                    }
                    else
                    {
                        result += 100;
                    }
                }
                else if (num[i] == 'L')
                {
                    result += 50;
                }
                else if (num[i] == 'X')
                {
                    if (i < num.Length - 1)
                    {
                        if (num[i + 1].Equals('L'))
                        {
                            result += 40;
                            i++;
                        }
                        else if (num[i + 1].Equals('C'))
                        {
                            result += 90;
                            i++;
                        }
                        else
                        {
                            result += 10;
                        }
                    }
                    else
                    {
                        result += 10;
                    }
                }
                else if (num[i] == 'V')
                {
                    result += 5;
                }
                else if (num[i] == 'I')
                {
                    if (i < num.Length - 1)
                    {
                        if (num[i + 1].Equals('V'))
                        {
                            result += 4;
                            i++;
                        }
                        else if (num[i + 1].Equals('X'))
                        {
                            result += 9;
                            i++;
                        }
                        else {
                            result++;
                        }
                    }
                    else
                    {
                        result++;
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int x = RomanToInt("III");
            Console.WriteLine("III is " + x);
            x = RomanToInt("IV");
            Console.WriteLine("IV is " + x);
            x = RomanToInt("IX");
            Console.WriteLine("IX is " + x);
            x = RomanToInt("LVIII");
            Console.WriteLine("LVIII is " + x);
            x = RomanToInt("MCMXCIV");
            Console.WriteLine("MCMXCIV is " + x);
            Console.ReadLine();
            
        }
    }
}
