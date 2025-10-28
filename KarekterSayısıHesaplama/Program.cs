using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarekterSayısıHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  
             *  1.Başla.
             *  2.Kullanıcıdan bir metin al.
             *  3.Sonucu saklamak için "sayaç" tanımla.
             *  4.Metnin başlangıcından sonuna kadar gidecek bir döngü kur.
             *  5.Döngünün her adımında sayacı arttır.
             *  6.Döngü tamamlanınca sayacı ekrana yazdır.
             *  7.Bitir.
             */

            Console.WriteLine("Bir metin giriniz");
            string metin = Console.ReadLine();

            int sayac = 0;
            foreach(char karakter in metin)
            {
                sayac++;
            }
            Console.WriteLine($"Girdiğiniz metnin karakter sayısı {sayac}" );
        }
    }
}
