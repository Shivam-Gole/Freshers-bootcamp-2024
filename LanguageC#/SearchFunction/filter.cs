using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFunction.cs
{
    public class filter
    {
      public  static List<string> Filter(List<string> arr, Func<string, bool> criteria)
        {
            List<string> answer = new List<string>();

            foreach (string element in arr)
            {
                if (criteria(element))
                {
                    answer.Add(element);
                }
            }
            return answer;
        }

         public static bool LengthGreaterThanThree(string s)
        {
            return s.Length > 3;
        }
    }
}
