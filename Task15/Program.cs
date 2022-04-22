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

            string sentence = "daaczcaad";
            string temp = sentence;

            

            bool stateSame = false;
            bool stateYanashiA = true;
            bool stateB = false;


            if (sentence[0]==sentence[sentence.Length-1])
            {
                stateSame = true;
            }


            if (temp==sentence.Replace("aa","aa"))
            {
                stateYanashiA = true;
            }
            else
            {
                stateYanashiA = false;
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
                string subIlk="", subSon="";
                if (sentence.Length%2==0)
                {
                    subIlk = sentence.Substring(0, sentence.Length / 2);
                    subSon = sentence.Substring(sentence.Length / 2, sentence.Length / 2);
                    subSon = string.Join("", subSon.ToCharArray().Reverse());
                }
                else if (sentence.Length % 2 != 0)
                {
                    subIlk = sentence.Substring(0, sentence.Length / 2 + 1);
                    subSon = sentence.Substring(sentence.Length / 2, sentence.Length / 2 +1 );
                    subSon = string.Join("", subSon.ToCharArray().Reverse());

                }
                

                if (subIlk==subSon)
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
