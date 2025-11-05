namespace SifreOlusturmaAlgoritması
{
    internal class Program
    /*
     ismin ilk 2 harfini büyük soyisimn son iki harfini küçük ve doğum tarihinin son iki rakamını al
     */
    {
        static void Main(string[] args)
        {
           Console.WriteLine("İsminizi giriniz");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminizi giriniz");
            string soyisim = Console.ReadLine();
            Console.WriteLine("doğum tarihinizi giriniz");
            DateTime tarih = Convert.ToDateTime(Console.ReadLine());
            string sifre = SifreOlustur(name, soyisim, tarih);
            Console.WriteLine("Şifre: " + sifre);
        }

        static string SifreOlustur(string name, string soyisim, DateTime tarih)
        {


            string sifre = name.Substring(0, 2).ToUpper() + soyisim.Substring(soyisim.Length - 2, 2).ToLower() + tarih.Year.ToString().Substring(2, 2);

            return sifre;

        }
    }
}
