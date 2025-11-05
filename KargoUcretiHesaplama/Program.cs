using System;

namespace KargoFonksiyonGeliştirmesi
{
    class KargoHesaplama
    {
        static void Main()
        {
            try
            {
                Console.Write("Kargo ağırlığı (kg): ");
                double kg = double.Parse(Console.ReadLine());

                Console.Write("Mesafe (km): ");
                int km = int.Parse(Console.ReadLine());

                double toplamUcret = ToplamKargoUcretiHesapla(kg, km);

                Console.WriteLine("\n Kargo ücreti başarıyla hesaplandı!");
            }
            catch (FormatException)
            {
                Console.WriteLine("\n Hata: Lütfen geçerli bir değer girin!");
            }

            Console.ReadKey();
        }

        static double ToplamKargoUcretiHesapla(double kg, int km)
        {
            double agirlikUcreti = AgirligaGoreUcret(kg);
            double mesafeUcreti = MesafeUcreti(km);

            double toplamUcret = agirlikUcreti + mesafeUcreti;

            Console.WriteLine($"Ağırlık Ücreti ({kg} kg): {agirlikUcreti:F2} TL");
            Console.WriteLine($"Mesafe Ücreti ({km} km): {mesafeUcreti:F2} TL");

            Console.WriteLine($"Toplam ÜCRET: {toplamUcret:F2} TL");

            return toplamUcret;
        }

        static double AgirligaGoreUcret(double kg)
        {
            double ucret = 0;

            if (kg <= 1)
            {
                ucret = 15.0;
            }
            else if (kg <= 5)
            {
                ucret = 15.0 + (kg - 1) * 5.0;
            }
            else if (kg <= 10)
            {
                ucret = 35.0 + (kg - 5) * 8.0;
            }
            else
            {
                ucret = 75.0 + (kg - 10) * 10.0;
            }

            return ucret;
        }

        static double MesafeUcreti(int km)
        {
            double ekUcret = 0;

            if (km <= 100)
            {
                ekUcret = 0;
            }
            else if (km <= 500)
            {
                ekUcret = (km - 100) * 0.5;
            }
            else
            {
                ekUcret = 200 + (km - 500) * 0.8;
            }

            return ekUcret;
        }
    }
}