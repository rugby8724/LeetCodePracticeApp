using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    internal class FizzBuzz
    {
        public IList<string> FBuzz(int n) {
            List<string> output = new List<string>();

            for(int i = 1; i <= n; i++)
            {
                if(i%3 == 0 && i%5 ==0)
                {
                    output.Add("FizzBuzz");
                   
                }
                else if(i%3 == 0)
                {
                    output.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    output.Add("Fizz");
                }
                else
                {
                    output.Add(i.ToString());
                }
            }
            return output;
        }
    }
}
