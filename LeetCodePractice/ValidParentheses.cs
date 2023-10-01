using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    internal class ValidParentheses
    {
        public static bool IsValid(string s)
        {
            Dictionary<char, int> bracketOpenings = new Dictionary<char, int>
            {
                {'(',1},
                {'{',2},
                {'[',3}
            };
            Dictionary<char, int> bracketClosings = new Dictionary<char, int>
            {
                {')',1},
                {'}',2},
                {']',3}
            };
            if (bracketClosings.ContainsKey(s[0]) || bracketOpenings.ContainsKey(s[s.Length - 1]))
            {
                    return false;
            }

            List<char> brackets = new List<char>();
            brackets.AddRange(s);

            bool output = true;

            do 
            {
                if (bracketClosings.ContainsKey(brackets[0]) || bracketOpenings.ContainsKey(brackets[brackets.Count - 1]))
                {
                    output = false;
                    break;
                }

                for (int i = 0; i < brackets.Count; i++)
                {
                    if (bracketOpenings.ContainsKey(brackets[i]))
                    {
                        continue;
                    }
                    else
                    {
                        if (bracketOpenings[brackets[i-1]] != bracketClosings[brackets[i]])
                        {
                            output = false; break;
                        }
                        else
                        {
                            brackets.RemoveRange(i-1, 2); break;
                        }
                    }
                }
            } 
            while (output && brackets.Count > 1);

            return output;



        }
    }
}
