using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestPalindrome
{
    class Program
    {
        public static string FindHighestPalindrome(string str, int k)
        {
            if (IsPalindrome(str))
            {
                return str;
            }
            else if (k <= 0)
            {
                return "-1";
            }
            else
            {
                char[] arr = str.ToCharArray();
                int n = arr.Length;
                int i = 0, j = n - 1;
                while (i <= j)
                {
                    if (arr[i] != arr[j])
                    {
                        char maxChar = (char)Math.Max(arr[i], arr[j]);
                        arr[i] = maxChar;
                        arr[j] = maxChar;
                        k--;
                    }
                    i++;
                    j--;
                }
                return FindHighestPalindrome(new string(arr), k);
            }
        }

        private static bool IsPalindrome(string str)
        {
            int i = 0;
            int j = str.Length - 1;

            while (i < j)
            {
                if (str[i] != str[j])
                {
                    return false;
                }
                i++;
                j--;
            }

            return true;
        }

        static void Main(string[] args)
        {
            string str = "3943";
            int k = 1;
            Console.WriteLine("Input:");
            Console.WriteLine($"string: {str}");
            Console.WriteLine($"k: {k}");
            Console.WriteLine($"Output: {FindHighestPalindrome(str, k)}\n");

            str = "3943";
            k = 2;
            Console.WriteLine("Input:");
            Console.WriteLine($"string: {str}");
            Console.WriteLine($"k: {k}");
            Console.WriteLine($"Output: {FindHighestPalindrome(str, k)}\n");
        }
    }
}
