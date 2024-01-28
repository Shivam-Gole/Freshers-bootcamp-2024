using System;
using System.Collections.Generic;

namespace Object_oriented
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string> { "Rohit", "Rahul", "Virat", "Jadeja", "JonSnow", "Aster" };

            Filter filter = new Filter();
            StringPredicate stringPredicate = new StringPredicate();

            var startsWithA = stringPredicate.CheckStringStartWithAny("A");
            var result = filter.FilterList(words, startsWithA);
            filter.PrintListToConsole(result);
        }
    }
}
