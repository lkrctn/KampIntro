using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "İlker ÇETİN";
            kurs2.IzlenmeOrani = 85;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Elif ÇETİN";
            kurs3.IzlenmeOrani = 96;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Hayat Dersi";
            kurs4.Egitmen = "Zeynep ÇETİN";
            kurs4.IzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs.Egitmen + " : " + kurs.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);

            }

        

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
