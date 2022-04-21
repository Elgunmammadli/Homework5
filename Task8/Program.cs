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
            string newWord="";
            for (int i = 0; i < 10; i++)
            {
                //newWord = string.Join("", sentence[index + 1]);
                newWord = sentence[index + 1].ToString();
                Console.Write(newWord);
            }
        }
    }
}
