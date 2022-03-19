using System;

namespace WhileForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While

            // 1 den başlayarak console'dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazdıran program.
            Console.WriteLine("Lütfen bir sayi giriniz!");
            int toplam = 0;
            int sayac = 1;
            int sayi = int.Parse(Console.ReadLine());
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine("1'den sayiya kadar olan sayilarin ortalaması: {0}", (toplam / sayi));

            // a dan z ye kadar tüm harfleri console a yazdır.
            char character = 'a';
            while (character < 'z')
            {
                Console.Write(character);
                character++;
            }

            //Foreach
            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}