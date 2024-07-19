using System;
using System.Security.Cryptography.X509Certificates;


namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "ELMA";
            urun1.Fiyati = 20;
            urun1.Aciklama = "Amasya elması";

            Product urun2 = new Product();
            urun2.Adi = "KARPUZ";
            urun2.Fiyati = 30;
            urun2.Aciklama = "Diyarbakır karpuzu";
            
            
            Product[] urunler = new Product[] { urun1, urun2, };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi + " " + urun.Fiyati + " " + urun.Aciklama);
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("   METOTOLAR     ");
            Console.WriteLine(" ");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            







        }
       
    }
}
