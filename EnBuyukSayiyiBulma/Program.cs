using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnBuyukSayiyiBulma
{
    internal class Program
    {
        /* -Girilen bir sayının basamaklarında ki en büyük sayıyı bulan program(485 -> 8)
         1- Başla 
         2- Kullanıcıdan sayı al.
         3- Sıfıra eşit bir int değer tanımla
         4- Basamakları ayrıştırabileceğin bir string değer tanımla
         5- Döngü de sıfırdan büyük mü kontorlü sağla.
            -- 10a bölümünden kalana bak.(Son basamak değerini almak için)
            -- Basamak adında bir değişkene atama yap.
         6- Eğer basamak enBuyukBasamak dan büyükse enBuyukBasamak'ın değeri basamak olur.
         7- Son basamağı atmak için 10a böl.
         8- En büyük basamağı yazdır.
         9- Bitir
        */
        static void Main(string[] args)
        {
            Console.Write("Bir sayı girin: ");
            int sayilar = Convert.ToInt32(Console.ReadLine());

            int enBuyukBasamak = 0;
            string basamaklar = "";

            while (sayilar > 0)
            {
                int basamak = sayilar % 10;

                basamaklar = basamak + basamaklar;

                if (basamak > enBuyukBasamak)
                {
                    enBuyukBasamak = basamak;
                }

                sayilar = sayilar / 10;
            }

            Console.WriteLine($"Girilen SAyı: {basamaklar}");
            Console.WriteLine($"\n✓ En büyük basamak: {enBuyukBasamak}");
            Console.ReadKey();
        }
    }
}
