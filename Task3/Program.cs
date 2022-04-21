using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             3) Verilmish metnde sol terefden tek yerde dayanan simvollardan necesi {b} -ye beraberdir.
             */

            Console.Write("Metn daxil et : ");
            string sentence = Convert.ToString(Console.ReadLine()); //"ana ata";
            int countB = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (sentence[i].ToString().ToUpper() == "B")
                    {
                        countB++;
                    }
                }
            }
             Console.WriteLine("tek yerde dayanan 'b' simvollarinin sayi : {0}",countB);
          
        }
    }
}
