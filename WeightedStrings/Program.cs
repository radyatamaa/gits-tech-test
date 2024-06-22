using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightedStrings
{
    class Program
    {
        public static List<string> CheckWeights(string s, int[] queries)
        {
            List<string> result = new List<string>();
            int[] weights = CalculateWeights(s);

            foreach (int query in queries)
            {
                bool found = false;
                for (int i = 0; i < s.Length; i++)
                {
                    for (int j = i + 1; j <= s.Length; j++)
                    {
                        int substringWeight = weights[j] - weights[i];
                        if (query == substringWeight)
                        {
                            result.Add("Yes");
                            found = true;
                            break;
                        }
                    }
                    if (found) break;
                }
                if (!found) result.Add("No");
            }

            return result;
        }

        private static int[] CalculateWeights(string s)
        {
            int[] weights = new int[s.Length + 1];
            weights[0] = 0;

            for (int i = 0; i < s.Length; i++)
            {
                weights[i + 1] = weights[i] + s[i] - 'a' + 1;
            }

            return weights;
        }

        static void Main(string[] args)
        {
            string s = "abbcccd";
            int[] queries = { 1, 3, 9, 8 };
            List<string> result = CheckWeights(s, queries);

            Console.WriteLine("Output: [" + string.Join(", ", result) + "]");
        }
    }
}
