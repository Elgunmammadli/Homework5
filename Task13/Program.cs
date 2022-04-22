
using System;

namespace Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              13) Verilimish metinde butun simvollari ardicil shekilde biri balaca, biri boyuk formada cap et. 
             */

            Console.Write("Metn daxil et: ");
            string sentence = Convert.ToString(Console.ReadLine());
            string temp = sentence;
            sentence = sentence.ToLower();
            for (int i = 0; i < sentence.Length; i++)
            {
                if (i%2!=0)
                {
                    sentence = sentence.Remove(i,1);
                    sentence = sentence.Insert(i, temp[i].ToString().ToUpper());
                }
            }
            Console.WriteLine(sentence);
        }
    }
}
