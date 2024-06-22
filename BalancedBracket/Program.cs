using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBracket
{
    class Program
    {
        public static string CheckBalancedBracket(string s)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>()
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

            foreach (char bracket in s)
            {
                if (bracketPairs.ContainsValue(bracket))
                {
                    if (stack.Count == 0 || bracketPairs[stack.Pop()] != bracket)
                    {
                        return "NO";
                    }
                }
                else if (bracketPairs.ContainsKey(bracket))
                {
                    stack.Push(bracket);
                }
            }

            return stack.Count == 0 ? "YES" : "NO";
        }

        static void Main(string[] args)
        {
            string[] inputs = { "{[()]}", "{[(])}", "{{[[(())]]}}" };
            foreach (string input in inputs)
            {
                Console.WriteLine($"Input: {input}");
                Console.WriteLine($"Output: {CheckBalancedBracket(input)}\n");
            }
        }
    }
}
