using System;

namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              11) Verilmish metinde butun {a} simvollarinin qabagina {b} simvolunu ve
              eyni zamandan butun {b} simvollarinin qabagina {a} simvolunu yaz. 
             */

            Console.Write("Metn daxil et: ");
            string sentence = Convert.ToString(Console.ReadLine());

            char a = 'a';
            char b = 'b';

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i]==a)
                {
                    sentence = sentence.Insert(i, b.ToString());
                    i++;
                }
                else if (sentence[i] == b)
                {
                    sentence = sentence.Insert(i, a.ToString());
                    i++;
                }
            }

            Console.WriteLine(sentence);










        }
    }
}
