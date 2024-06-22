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
                if (bracketPairs.ContainsKey(bracket))
                {
                    stack.Push(bracket);
                }
                else if (bracketPairs.ContainsValue(bracket))
                {
                    if (stack.Count == 0 || bracketPairs[stack.Pop()] != bracket)
                    {
                        return "NO";
                    }
                }
                else if (bracket != ' ' && bracket != '\t' && bracket != '\n')
                {
                    return "INVALID CHARACTER, ONLY ABLE BRACKET (),{},[]";
                }
            }

            return stack.Count == 0 ? "YES" : "NO";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Click 'x' to exit, or enter a string containing brackets:");

            while (true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    continue;
                }

                Console.WriteLine($"Input: {input}");
                Console.WriteLine($"Output: {CheckBalancedBracket(input)}");
            }
        }
    }
}
