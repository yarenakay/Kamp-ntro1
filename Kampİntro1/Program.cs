using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself 
            //değer tutucu - alias (kategori etiketi)
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");

            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");            
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }
             

            if (sistemeGirisYapmismi == true) // if eğer şart geçerliyse aşağıdaki blok çalışssın
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            } 
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);





        }
    }
}
