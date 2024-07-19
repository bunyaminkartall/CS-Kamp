// Emre Bey'e aldığın çıktıda Menüleri neden en üstte yazdığını sor!!



using System;

namespace Test2
{ 
     class Program
    {
        static void Main(string[] args)
        {
            Menu menu1 = new Menu();
            menu1.MenuAdi = "MENÜ1 : ";
            menu1.Baslangiclar = "Mercimek Çorbası";
            menu1.AraSicaklar = "İçli Köfte";
            menu1.AnaYemekler = "Kayseri Mantısı";
            menu1.Tatlilar = "Sütlaç";
            menu1.Icicekler = "Meşrubat";
            menu1.Fiyatlar = 350;


            Menu menu2 = new Menu();
            menu2.MenuAdi = "MENÜ2 : ";
            menu2.Baslangiclar = "Ezogelin Çorbası";
            menu2.AraSicaklar = "Çiğköfte";
            menu2.AnaYemekler = "Karışık Izgara";
            menu2.Tatlilar = "Güllaç";
            menu2.Icicekler = "Meşrubat";
            menu2.Fiyatlar = 600;


            Menu menu3 = new Menu();
            menu3.MenuAdi = "MENÜ3 : ";
            menu3.Baslangiclar = "Yoğurt Çorbası";
            menu3.AraSicaklar = "Patates Kızartması";
            menu3.AnaYemekler = "Izgara Köfte";
            menu3.Tatlilar = "Magnolya";
            menu3.Icicekler = "Meşrubat";
            menu3.Fiyatlar = 400;

            Menu[] menuler = new Menu[] { menu1, menu2, menu3 };

            foreach (var menu in menuler)
            {
                Console.WriteLine(menu.MenuAdi + menu.Baslangiclar + " / " + menu.AraSicaklar + " / " + menu.AnaYemekler + " / " + menu.Tatlilar + " / " + menu.Icicekler 
                 + " / " + menu.Fiyatlar  + "TL" );
            }
            Console.WriteLine(" ");
            for (int i = 0; i < menuler.Length; i++)
            {
                Console.WriteLine(menuler[i].MenuAdi + " / " + menuler[i].Baslangiclar + " / " + menuler[i].AraSicaklar + " / " + menuler[i].AnaYemekler + " / " + menuler[i].Tatlilar + " / " + menuler[i].Icicekler + " / " + menuler[i].Fiyatlar + "TL");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Çay Servisimiz Sınırsınzıdır");
        }
       
            

	}
   class Menu
    {
        public string MenuAdi { get; set; }
        public string Baslangiclar { get; set; }
        public string AraSicaklar { get; set; }
        public string AnaYemekler { get; set; }
        public string Tatlilar { get; set; }
        public string Icicekler { get; set; }
        public int Fiyatlar { get; set; }
    }
}
