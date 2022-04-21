using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               4) Verilmish metnde sol terefden ilk rast gelinen {a} simvolunun yeri tek ededdi yoxsa cut ?
             */

            Console.Write("Metn daxil et: ");
            string sentence = Convert.ToString(Console.ReadLine());
            char[] forA = { 'A', 'a' };
            int index = sentence.IndexOfAny(forA,0);

            if (index % 2 == 0)
            {
                Console.WriteLine("ilk 'a' simvolu tek yerdedir : {0} ci yer",index + 1);
            }
            else
            {
                Console.WriteLine("ilk 'a' simvolu cut yerdedir : {0} ci yer", index + 1);
            }
        }
    }
}
