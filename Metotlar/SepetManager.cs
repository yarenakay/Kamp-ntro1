using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        // namiing convention
        //syntax
        //Neyi eklemek istediğini vermen gerek bujna parametre denir
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler! Sepete eklendi :" + urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama , double fiyatı, int stokAdedi)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi : " + urunAdi);

        }


    }
}
