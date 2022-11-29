using System;
using System.Collections;

namespace soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList result = new ArrayList();
            Console.WriteLine("please enter a sentence: ");
            string sentence=Console.ReadLine();
            string vowels="aeoöıiuü AEOÖIİUÜ";
            foreach (char item in sentence)
            {
                if (vowels.ToString().Contains(item))
                {
                    result.Add(item);
                }
            }
            result.Sort();
                Console.WriteLine("item");
            foreach (var item in result)
            {
                Console.Write(item);
            }
        }
    }
}
