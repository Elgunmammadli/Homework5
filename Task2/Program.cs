using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             2) Verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi {a} simvoludurmu?
             */
            Console.Write("Metn daxil et : ");
            string sentence = Convert.ToString(Console.ReadLine()); //"ana ata";
            int countA = 0;
            int countOddIndex = (sentence.Length+1)/2;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (i%2==0)
                {
                    if (sentence[i].ToString().ToUpper()=="A")
                    {
                        countA++;
                    }
                }
            }
            if (countOddIndex == countA)
            {
                Console.WriteLine("hamisi a simvoludur");
            }
            else {
                Console.WriteLine("hamisi a simvolu deyil");
            }
        }
    }
}
