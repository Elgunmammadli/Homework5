using System;

namespace Task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              14) Verilmish metinde butun tek yerde dayanan simvollari ondan sonra gelen simvolun BOYUK formasi ile evez et. 
             */
            Console.Write("Metn daxil et: ");
            string sentence = Convert.ToString(Console.ReadLine());


            for (int i = 0; i < sentence.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    sentence = sentence.Insert(i + 1, sentence[i + 1].ToString().ToUpper());
                    sentence = sentence.Remove(i, 1);
                }
            }
            Console.WriteLine(sentence);
        }
    }
}
