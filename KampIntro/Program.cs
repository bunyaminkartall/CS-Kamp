using System;

namespace KampIntro
{
    class Program
    {
        public static void Main(string[] args)
        {
            string categoryTag = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;           //Ondalıklı sayıları double ve float tutar
            bool checkPoint = false; */ 
                                               //Değerleri doğru ya da yanlış olabilecek durumlar için kullanılır.
                                               //Gerçek hayatta 1 ya da 0 karşılığı bir veri kaynağından gelir.
                                               // bool sistemeGirisYapmisMi = ddddddd();
                                               //Yukarıdaki örnekteki gibi karışılığında bir fonksiyon olur normalde.
            double dollarYesterday = 7.35;
            double dollarToday = 7.45;

            if (dollarYesterday > dollarToday)
            {
                Console.WriteLine("Azalış Görseli");
            }
            else if ( dollarYesterday < dollarToday)
            {
                Console.WriteLine("Artış Görseli");
            }
            else // ( dollarYesterday == dollarToday)
            {
                Console.WriteLine("Sabit Görseli");
            }




            // Console.WriteLine(categoryTag);

            if (checkPoint == true)
            {
                Console.WriteLine("Kullanıcı ayarı butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }



        }


    }
}
