using System;

namespace KampIntro
{
    class Program
    {
        public static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;           //Ondalıklı sayıları double ve float tutar
            bool sistemeGirisYapmisMİ = false; //Değerleri doğru ya da yanlış olabilecek durumlar için kullanılır.
                                               //Gerçek hayatta 1 ya da 0 karşılığı bir veri kaynağından gelir.
                                               // bool sistemeGirisYapmisMi = ddddddd();
                                               //Yukarıdaki örnekteki gibi karışılığında bir fonksiyon olur normalde.
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Görseli");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Görseli");
            }
            else // (dolarDun == dolarBugun)
            {
                Console.WriteLine("Sabit Görseli");
            }




            // Console.WriteLine(kategoriEtiketi);

            if (sistemeGirisYapmisMİ == true)
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