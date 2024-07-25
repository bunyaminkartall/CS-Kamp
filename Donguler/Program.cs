using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string course1 = "yazılım geliştirici yetiştirme kursu";
            //string course2 = " programlamaya başlangıç için temel kursu";
            //string course3 = "java kursu";

            //array - dizi

            string[] courses = new string[] {"Yazılım Geliştirici Yetiştirme Kampı","Programlamaya Başlangıç İçin Temel Kursu",
                "Java Kursu","Python Kursu","OOP Kursu","SAP Kursu"};

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }
            Console.WriteLine();
            Console.WriteLine("For Döngüsü Bitti");
            Console.WriteLine("--------------------");
            Console.WriteLine("Foreach Döngüsü Başladı");
            Console.WriteLine();

            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }
            Console.WriteLine();
            Console.WriteLine("Sayfa Sonu");
        }
    }
}
