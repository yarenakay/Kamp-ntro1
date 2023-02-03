using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";


            Urun[] urunler = new Urun[] { urun1, urun2 };


            //type-safe
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------");


            }
            //Metot tekrar tekrar aynı şeyi kullanabilme özelliği
            Console.WriteLine("-------Metotlar-----");

            //instance - class örneği oluşturma
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşi Armut", 12,10);
            sepetManager.Ekle2("elma", "Yeşil elma", 12,9);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 12,8);
          

        }
    }
}


//dont repeat yourself - DRY - Clean Code - Best Practice





