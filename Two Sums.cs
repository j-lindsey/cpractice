using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sums
{
    class Program
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int [] result = new int [2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (target == (nums[i] + nums[j]))
                    { 
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }
        }
        static void Main(string[] args)
        {   
            
            Console.WriteLine("Please enter the number array");
            Console.ReadLine("")
        }
    }
}
