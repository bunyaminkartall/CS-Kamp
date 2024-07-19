using System;


namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ulasimAraclari = new string[] { "araba", "motorsiklet", "uçak", "gemi", "bisiklet","yürüyen uçak" };

            for (int i = 0; i < ulasimAraclari.Length; i++)
            {
                Console.WriteLine(ulasimAraclari[i]);
            }
            Console.WriteLine();
            Console.WriteLine("For Döngüsü Bitti");
            Console.WriteLine("--------------------");
            Console.WriteLine("Foreach Döngüsü Başladı");

            foreach (string araclar in ulasimAraclari)
            {
                Console.WriteLine(araclar);   
            }
            Console.WriteLine();
            
        }
    }
}
