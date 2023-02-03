using System;
namespace Classİntro
{
    class Program

    {
        static void Main(string[] args)
        {
            string adi = "engin";
            int yas = 32;

            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.Egitmen = "Engin";
            kurs1.IzlenmeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Java";
            kurs2.Egitmen = "kerem";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "python";
            kurs3.Egitmen = "berkey";
            kurs3.IzlenmeOrani = 70;

            //Console.WriteLine(kurs1.kursAdi + " : "  + kurs1.Egitmen );


            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " : " + kurs.Egitmen);

            }
            
                
        }
    }

    class Kurs
    {
        public string kursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }

    }
}