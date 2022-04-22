using System;
using System.Collections.Generic;
using System.Linq;


namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              12) Verilmish metinde en ilk ve en son {a} simvolundan bashqa yerde qalan butun {a} simvollarini yox et. 
             */

            Console.Write("Metn daxil et: ");
            string sentence =  Convert.ToString(Console.ReadLine());
           

            int indexIlk = sentence.IndexOf('a', 0);
            int indexSon = sentence.LastIndexOf('a', sentence.Length - 1);
            string temp = sentence;
            string temp2=sentence;

            List<int> intList = new List<int>();
            int index = -1;

            do
            {
                index = sentence.IndexOf('a', index + 1);
                if (index < 0) break;

                intList.Add(index);
            } while (true);

            for (int i = 0; i < intList.Count; i++)
            {
                if (!(intList[i] == indexIlk || intList[i] == indexSon))
                {
                    temp = sentence.Remove(intList[i], 1);
                    sentence = temp.Insert(intList[i], "`#@;';';");
                }
            }

            sentence = sentence.Replace("`#@;';';", "");// chox dusundum bele bir chare tapdim :) .'`#@;';';' bu characterler demek olar ki yanashi ishlenmez :)

            Console.WriteLine(sentence);
        }
    }
}
