using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "c#";

            //array-dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç için temel kurs", "Java","python","c#" }; 

            for (int i = 0; i < kurslar.Length; i++) //i den başla 10 a kadar 1 1 artır //+=2 şeklinde de yazılır
            {
                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("for bitti");



            foreach (string kurs in kurslar) //foreach -  dizi temelli yapıların elemenlarını tek tek dolaşmaya yarar
            {
                Console.WriteLine(kurs);

            }

            Console.WriteLine("sayfa sonu - footer");
        }

    }
}
