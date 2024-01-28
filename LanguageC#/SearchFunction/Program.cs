using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFunction.cs
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string> { "Rohit", "Zac", "Virat", "Ash", "Rahul" };

            List<string> filteredWords = filter.Filter(words, filter.LengthGreaterThanThree);

            Console.Write("Words with length greater than 3: ");
            foreach (string word in filteredWords)
            {
                Console.Write(word + " ");
            }
        }
    }
}
