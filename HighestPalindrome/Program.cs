using System;

namespace HighestPalindrome
{
    class Program
    {
        public static string FindHighestPalindrome(string str, int k)
        {
            char[] arr = str.ToCharArray();
            int n = arr.Length;
            int i = 0;
            int j = n - 1;
            int replacements = 0;

            
            while (i < j)
            {
                if (arr[i] != arr[j])
                {
                    arr[i] = arr[j] = (char)Math.Max(arr[i], arr[j]);
                    replacements++;
                }
                i++;
                j--;
            }

            
            if (replacements > k)
            {
                return "-1";
            }

            i = 0;
            j = n - 1;

            
            while (i <= j && k > replacements)
            {
                if (i == j)
                {
                    
                    arr[i] = '9';
                    break;
                }

                if (arr[i] != '9')
                {
                    if (replacements < k && arr[i] == str[i] && arr[j] == str[j])
                    {
                        
                        arr[i] = arr[j] = '9';
                        k -= 2;
                    }
                    else if (replacements == k && arr[i] != str[i] && arr[j] != str[j])
                    {
                        
                        arr[i] = arr[j] = '9';
                        k--;
                    }
                }

                i++;
                j--;
            }

            return new string(arr);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a string:");
                string str = Console.ReadLine();

                Console.WriteLine("Enter k:");
                if (!int.TryParse(Console.ReadLine(), out int k))
                {
                    Console.WriteLine("Invalid input for k.");
                    continue;
                }

                Console.WriteLine($"Input:");
                Console.WriteLine($"string: {str}");
                Console.WriteLine($"k: {k}");
                Console.WriteLine($"Output: {FindHighestPalindrome(str, k)}\n");

                Console.WriteLine("Click 'x' to exit, or any other key to continue...");
                if (Console.ReadKey().Key == ConsoleKey.X)
                {
                    break;
                }
                Console.WriteLine(); 
            }
        }
    }
}
