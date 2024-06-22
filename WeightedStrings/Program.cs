using System;
using System.Collections.Generic;

namespace WeightedStrings
{
    class Program
    {
        public static List<string> CheckWeights(string s, int[] queries)
        {
            List<string> result = new List<string>();
            HashSet<int> weights = new HashSet<int>();

            int i = 0;
            while (i < s.Length)
            {
                int currentWeight = 0;
                int repeatCount = 0;
                char currentChar = s[i];
                while (i < s.Length && s[i] == currentChar)
                {
                    repeatCount++;
                    currentWeight += s[i] - 'a' + 1;
                    weights.Add(currentWeight);
                    i++;
                }
            }

            foreach (int query in queries)
            {
                result.Add(weights.Contains(query) ? "Yes" : "No");
            }

            return result;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a string:");
                string s = Console.ReadLine();

                Console.WriteLine("Enter the number of queries:");
                int queryCount;
                while (!int.TryParse(Console.ReadLine(), out queryCount) || queryCount < 1)
                {
                    Console.WriteLine("Please enter a valid number of queries.");
                }

                int[] queries = new int[queryCount];
                for (int i = 0; i < queryCount; i++)
                {
                    Console.WriteLine($"Enter query {i + 1}:");
                    while (!int.TryParse(Console.ReadLine(), out queries[i]) || queries[i] < 0)
                    {
                        Console.WriteLine("Please enter a valid query.");
                    }
                }

                List<string> result = CheckWeights(s, queries);

                Console.WriteLine("Output: [" + string.Join(", ", result) + "]");

                Console.WriteLine("Click 'x' to exit, or any other key to continue...");
                ConsoleKeyInfo key = Console.ReadKey(intercept: true);
                if (key.Key == ConsoleKey.X)
                {
                    break;
                }
                Console.Clear();
            }
        }
    }
}