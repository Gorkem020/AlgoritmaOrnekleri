namespace kullanicidanAlinanİsimSoyismiFormatlama
{
    /* kullanıcıdan alınan isim ve soyismin baş harflerini büyük diğer harflerini küçük harf yazan algoritma */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("İsim girin: ");
            string isim = Console.ReadLine();

            Console.Write("Soyisim girin: ");
            string soyisim = Console.ReadLine();

            Console.WriteLine($"Düzenlenmiş: {Duzenle(isim, soyisim)}");
        }
        static string Duzenle(string ad, string soyad)
        {
            ad = char.ToUpper(ad[0]) + ad.Substring(1).ToLower(); // SUBSTRİNG : BİR STRİNG DEGERININ BELRİLİ BİR İNDİSTEN DİĞER INDISE KADAR SEÇMEMİZİ SAĞLAR 
            soyad = char.ToUpper(soyad[0]) + soyad.Substring(1).ToLower();

            return ad + " " + soyad; // Bünyamin Pilsim -> B + ünyamin 

        }
    }
}
