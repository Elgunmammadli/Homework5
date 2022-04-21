using System;
using System.Linq;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            9) Verilmish metinde ilk 3 simvol, son 3 simvolun tersine formasina beraberdirmi.?
            */

            Console.Write("Metn daxil et: ");
            string sentence = Convert.ToString(Console.ReadLine());

            string ilk3 = sentence.Substring(0, 3);
            string son3 = sentence.Substring(sentence.Length - 3, 3);

            string reverseSon3 = string.Join("",son3.ToCharArray().Reverse());

            if (ilk3 == reverseSon3)
            {
                Console.WriteLine("beraberdir");
            }
            else
            {
                Console.WriteLine("beraber deyil");
            }
        }
    }
}
