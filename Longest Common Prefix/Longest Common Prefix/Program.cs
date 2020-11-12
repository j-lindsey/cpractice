using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Common_Prefix
{
    class Program
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            string result = strs[0];
            for (int i = 1; i < strs.Length; i++) {
                while (strs[i].IndexOf(result) != 0) {
                    result = result.Substring(0, result.Length - 1);
                    if (string.IsNullOrEmpty(result)) return "";
                }
            }
            return result;
        }
    
    static void Main(string[] args)
    {
        string[] strs = { "flower", "flow", "flight" };
        string prefix = LongestCommonPrefix(strs);
        Console.WriteLine("Prefix " + prefix);
        string[] strs1 = { "dog", "racecar", "car" };
        prefix = LongestCommonPrefix(strs1);
        Console.WriteLine("Prefix " + prefix);
            Console.ReadLine();
    }
}
    
}
