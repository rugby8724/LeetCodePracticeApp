using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    internal class UniqueNumOfOccurrences
    {
        public static bool UniqueOccurrences(int[] arr)
        {
            if(arr.Length == 1) return true;

            List<int> occurrences = new List<int>();
            Array.Sort(arr);

            int count = 1;

            for (int i  = 0; i < arr.Length; i++) 
            {
                occurrences.ForEach(x => Console.WriteLine(x));
                if (i + 1 == arr.Length)
                {
                    if (arr[i] == arr[i - 1])
                    {
                        break;
                    }
                    else
                    {
                        return !occurrences.Contains(1);
                    }
                }
                else if (arr[i] == arr[i + 1])
                {
                    count++;
                }
                else
                {
                    if (occurrences.Contains(count))
                    {
                        return false;
                    }
                    else
                    {
                        occurrences.Add(count);
                        count = 1;
                    }
                }
            }

            return true;

        }
    }
}
