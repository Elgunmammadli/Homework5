using System;
using System.Linq;

namespace Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              15)* Verilmish metinde ilk ve son simvol eynidirse,
              ve metn daxilinde yanashi gelen {a} simvolu varsa,
              ve metn daxilinde {b} simvolu yoxdursa
              o zaman bu metnde butun {c} simvollari yox et ve
              neticede alinan metn zerkalni olub olmadigini yoxla.
             */

            Console.Write("Metn daxil et: ");
            string sentence = Convert.ToString(Console.ReadLine());

            bool stateSame = false;
            bool stateYanashiA = false;
            bool stateB = false;


            if (sentence[0]==sentence[sentence.Length-1])
            {
                stateSame = true;
            }

            for (int i = 0; i < sentence.Length-1; i++)
            {
                if (sentence[i]=='a' && sentence[i]==sentence[i+1])
                {
                    stateYanashiA = true;
                }
            }

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i]=='b')
                {
                    stateB = true;
                    break;
                }
                break;
            }

            if (stateSame==true && stateYanashiA==true && stateB==false)
            {
                sentence = sentence.Replace("c", "");
                string reverse = string.Join("", sentence.ToCharArray().Reverse());
               
                if (sentence== reverse)
                {
                    Console.WriteLine("zerkalnidir");
                }
                else
                {
                    Console.WriteLine("zerkalni deyil");
                }
            }
            else
            {
                Console.WriteLine("Shert odenmir");
            }
        }
    }
}
