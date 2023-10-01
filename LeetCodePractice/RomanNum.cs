using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    internal class RomanNum
    {
        public static int RomanToInt(string s)
        {
            Dictionary<char, int> romanNumerals = new Dictionary<char, int>
        {
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000}
        };

            int total = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char currentLetter = s[i];
                if (i < s.Length - 1)
                {
                    char nextLetter = s[i + 1];

                    if (romanNumerals[currentLetter] < romanNumerals[nextLetter])
                    {
                        total += (romanNumerals[nextLetter] - romanNumerals[currentLetter]);
                        i++;
                        continue;
                    }
                }
                total += romanNumerals[currentLetter];

            }
            return total;
        }
    }
}
