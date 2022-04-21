using System;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               7) Verilmish metnde {a} simvolu {b} simvolundan qabaq ve oda {c} simvolundan qabaq gelirmi?
             */

            Console.Write("Metn daxil et: ");
            string sentence = Convert.ToString(Console.ReadLine());
            char[] charA = { 'A', 'a' };
            char[] charB = { 'B', 'b' };
            char[] charC = { 'C', 'c' };
            int indexA = sentence.IndexOfAny(charA,0);
            int indexB = sentence.IndexOfAny(charB,0);
            int indexC = sentence.IndexOfAny(charC,0);

            if (indexA<indexB && indexB<indexC)
            {
                Console.WriteLine($" 'a' simvolu(yeri :{indexA+1}), 'b' simvolundan qabaqda(yeri: {indexB+1}) O DA 'c' simvolundan qabaqda(yeri: {indexC+1}) gelir");
            }
            else
            {
                Console.WriteLine("Xeyr,gelmir");
            }
        }
    }
}
