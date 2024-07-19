using System;

namespace ClassIntro
{
    class Program
    {

        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs(); // int, string gibi class şeklinde birden fazla veri barındırıyor içinde
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Bünyamin Kartal";
            kurs1.IzlenmeOranı = 34;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "Arda Tezbaşaran";
            kurs2.IzlenmeOranı = 70;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.Egitmen = "Melisa Kabuk";
            kurs3.IzlenmeOranı = 12;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};//Emre Beye burayı sormayı unutma
            // önceden string list'in içinde sadece string tutuyorduk fakat şimdi Kurs tutuyoruz
            Console.WriteLine("-Foreach Döngüsünü Kullanıyoruz-");
            Console.WriteLine();
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + "/" + kurs.IzlenmeOranı);

            }
            Console.WriteLine();
            Console.WriteLine("-For Döngüsünü Kullanıyoruz-");
            Console.WriteLine();

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i].KursAdi + " : " + kurslar[i].Egitmen + "/" + kurslar[i].IzlenmeOranı );
            }
            Console.WriteLine();
           
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; } // prop yazıp iki kere tab a basıyoruz burda
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }
    }
}

