using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInteger
{
    class Program
    {
        public static int Reverse(int x)
        {
            bool neg = false;
            string num;
            if (x < 0)
            {
                neg = true;
                try
                {
                    int num3 = checked(-1*x);
                    num = (num3).ToString();
                }
                catch (OverflowException)
                {
                    num = "0";
                }
      
            }
            else {
                num = x.ToString();
            }
            char[] individualNum = num.ToCharArray();
            Array.Reverse(individualNum);
            while (individualNum[0] == '0' && individualNum.Length > 1) {
                individualNum = individualNum.Skip(1).ToArray();
            }
            for (int i = 0; i < individualNum.Length; i++) {
                Console.Write(individualNum[i] + ", ");
            }
            Console.WriteLine();
            string num2 = new string(individualNum);
            int result;
            try
            {
                result = checked(int.Parse(num2));
            }
            catch (OverflowException)
            {
                result = 0;
            }
            if (neg == false) {
                return result;
            }
            else {
                return -1 * result;
            }

        }
        static void Main(string[] args)
        {
            int result = Reverse(-2147483648);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
