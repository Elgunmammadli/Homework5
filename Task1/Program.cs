using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               1) Verilmish metnde {a} simvolun sayi {b} simvolun sayinda nece defe coxdur?
             */
            Console.Write("Metn daxil et: ");
            string sentence = Convert.ToString(Console.ReadLine());

            double countA = 0;
            double countB = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i].ToString().ToUpper() == "A")
                {
                    countA++;
                }
                else if (sentence[i].ToString().ToUpper() == "B")
                {
                    countB++;
                }
            }
            if (countA==0 )
            {
                Console.WriteLine($"a simvolu yoxdur b simvolu sayi :{countB}");
                return;
            }
            else if (countB == 0)
            {
                Console.WriteLine($"b simvolu yoxdur a simvolu sayi :{countA}");
                return;
            }
            double qismet = countA / countB;
            Console.WriteLine("a simvollarinin sayi ,b simvollarin sayindan {0} defe  choxdur", qismet);
        }
    }
}
