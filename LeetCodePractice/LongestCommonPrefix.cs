using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    internal class LongestCommonPrefix
    {
        public static string LongCommonPrefix(string[] strs)
        {
            string longestCommon = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                var min = Math.Min(longestCommon.Length, strs[i].Length);

                for (int j = 0; j < min; j++)
                {
                    if (longestCommon[j] == strs[i][j])
                    {
                        if(j == min-1)
                        {
                            longestCommon = longestCommon.Substring(0, min);
                        }
                        continue;
                    }
                    else
                    {
                        if (j == 0)
                        {
                            return "";
                        }
                        else
                        {
                            longestCommon = longestCommon.Substring(0, j);
                            break;
                        }

                    }
                }
            }
            return longestCommon;



        }
    }
}
