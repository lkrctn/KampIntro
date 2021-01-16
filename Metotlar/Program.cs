using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type safe - tip güvenli
            foreach (var urun in urunler)
            {
                Console.WriteLine("urun.Adi");
                Console.WriteLine("urun.Fiyati");
                Console.WriteLine("urun.Aciklama");
                Console.WriteLine("-----------------------");

            }
           

            Console.WriteLine("---------Metotlar------------");
                           


        }
    }
}

//Do not repeat yourself. Kendini tekrar etme. DRY - Clean Code - Best Practice(Doğru uygulama teknikleri)