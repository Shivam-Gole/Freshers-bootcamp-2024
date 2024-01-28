using System;
using System.Collections.Generic;
using System.Linq;

namespace Object_oriented
{
    public class Filter
    {
        public List<string> FilterList(List<string> words, Func<string, bool> criteria)
        {
            return words.Where(criteria).ToList();
        }

        public void PrintListToConsole(List<string> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
    }
}
