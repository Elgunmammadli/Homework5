using System;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             5) Verilmish metnde sol terefden saydiqda {a},{b},{c} simollarindan hansi birinci gelir?
             */

            Console.Write("Metn daxil et: ");
            string sentence = Convert.ToString(Console.ReadLine());

            char[] chars = { 'a', 'b', 'c' };
            int index = sentence.IndexOfAny(chars,0);

            Console.WriteLine($"'{sentence[index]}' birinci gelir. yeri: {index+1} ");
        }
    }
}
