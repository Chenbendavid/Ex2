using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.Arrays
{
    internal class ExArray
    {
        public void StringWords()
        {
            string[] words = { "Csharp", "is", "a", "general", "purpose", "computer", "programming", "language" };
            Console.WriteLine(words[5]);
            Console.WriteLine(words[6]);
            Console.WriteLine(words[7]);
            Console.ReadKey();
        }

        public void StringWords2()
        {
            string words = "Csharp,is,a,general,purpose,computer,programming,language,love";
            string[] words2 = words.Split(',');
            Console.WriteLine(words2[words2.Length - 3]);
            Console.WriteLine(words2[words2.Length - 2]);
            Console.WriteLine(words2[words2.Length - 1]);
            Console.ReadKey();
        }

        public void PeapleAndPlaces()
        {
            string[,] arrayPeapleAndPlaces = { { "Moshe", "22", "Jerusalem"} , { "Joseph", "45", "London"} };
            Console.WriteLine(arrayPeapleAndPlaces[0,0]);
            Console.ReadKey();
        }
    }
}


