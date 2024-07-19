using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "yazılım geliştirici yetiştirme kursu";
            //string kurs2 = " programlamaya başlangıç için temel kursu";
            //string kurs3 = "java kursu";

            //array - dizi

            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı","Programlamaya Başlangıç İçin Temel Kursu",
                "Java Kursu","Python Kursu","OOP Kursu","SAP Kursu"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine();
            Console.WriteLine("For Döngüsü Bitti");
            Console.WriteLine("--------------------");
            Console.WriteLine("Foreach Döngüsü Başladı");
            Console.WriteLine();

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine();
            Console.WriteLine("Sayfa Sonu");
        }
    }
}
