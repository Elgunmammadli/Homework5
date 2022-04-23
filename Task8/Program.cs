using System;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               8) Verilmish metnde ilk qabagima cixan {a} simvolundan sonra gelen simvolu 10 defe dalbadal cap et.

             */

            Console.Write("Metn daxil et: ");
            string sentence = Convert.ToString(Console.ReadLine());
            char[] charA = { 'A', 'a' };

            int index = sentence.IndexOfAny(charA,0);
            for (int i = index; i < index+9; i++)
            {
                sentence = sentence.Insert(i+1,sentence[i+1].ToString());
            }
            Console.Write(sentence);

        }
    }
}
