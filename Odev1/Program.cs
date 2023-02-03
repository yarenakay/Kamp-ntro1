using System;
namespace Odev1
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hello World");


            Urun urun1 = new Urun();
            urun1.urunAdi = "Iphonex";
            urun1.urunFiyatı = 9600;
            urun1.indirimOrani = 18;
            urun1.gorenSayisi = 10689;


            Urun urun2 = new Urun();
            urun2.urunAdi = "Iphone8";
            urun2.urunFiyatı = 7000;
            urun2.indirimOrani = 15;
            urun2.gorenSayisi = 654;

            Urun urun3 = new Urun();
            urun3.urunAdi = "ıphone7";
            urun3.urunFiyatı = 16000;
            urun3.indirimOrani = 16;
            urun3.gorenSayisi = 654;


            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            for (int i = 0; i < urunler.Length; i++)
            {

                Console.WriteLine("Ürün Adı" + urunler[i].urunAdi + "Ürün Fiyatı" + urunler[i].urunFiyatı + "İndirim Oranı" + urunler[i].indirimOrani + "Gösterim" + urunler[i].gorenSayisi);

            Console.WriteLine("-----for bitti----");

                foreach (var urun in urunler)
                {
                    Console.WriteLine("Ürün Adı" + urunler[i].urunAdi + "Ürün Fiyatı" + urunler[i].urunFiyatı + "İndirim Oranı" + urunler[i].indirimOrani + "Gösterim" + urunler[i].gorenSayisi);  //mavi urunler yerine urun olacak....


                    Console.WriteLine("-----foreach-Bitti----");
                int a = 0;
                while (a < urunler.Length)
                {
                    Console.WriteLine("Ürün Adı" + urunler[i].urunAdi + "Ürün Fiyatı" + urunler[i].urunFiyatı + "İndirim Oranı" + urunler[i].indirimOrani + "Gösterim" + urunler[i].gorenSayisi);
                    a++;


                }
                Console.WriteLine("while bitti");









        }
    }
    class Urun
    {
        public string urunAdi { get; set;}

        public int urunFiyatı { get; set; }

        public int indirimOrani { get; set; }

        public int gorenSayisi { get; set; }
    }

}