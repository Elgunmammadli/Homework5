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

            string newSen = sentence.Replace("a","ab");
            string newSenn = newSen.Replace("b", "ba");

            Console.WriteLine(newSenn);










        }
    }
}
