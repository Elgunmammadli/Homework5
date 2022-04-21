using System;
using System.Text.RegularExpressions;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              10) Verilmish metinde butun reqemleri legv et. 
             */

            Console.Write("Metn daxil et: ");
            string sentence = Convert.ToString(Console.ReadLine());

            string newSentence = Regex.Replace(sentence, @"\d", "");

            Console.WriteLine(newSentence);
        }
    }
}
