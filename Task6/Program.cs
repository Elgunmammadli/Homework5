﻿using System;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               6) Verilmish metnde {a} simvolunun sol terefden ve sag terefden indexleri eydidirmi?
             */

            Console.Write("Metn daxil et: ");
            string sentence = Convert.ToString(Console.ReadLine());
            char[] forA = { 'A', 'a' };//salam

            int index1 = sentence.IndexOfAny(forA, 0);
            int index2 = sentence.LastIndexOfAny(forA, sentence.Length-1);
            index2 = sentence.Length - index2 - 1;
            
            if (index1==index2)
            {
                Console.WriteLine("eynidir");
            }
            else
            {
                Console.WriteLine("eyni deyil");
            }
        }
    }
}
