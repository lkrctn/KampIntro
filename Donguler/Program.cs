using System;

namespace Donguler
{
    class Program
    {
             
        //array - dizi

        
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
            "Programlamaya başlangıç için temel kurs",
            "Java","Python", "C#" };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("foreach bitti");

            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
