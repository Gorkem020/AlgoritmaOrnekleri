using System.Security.Cryptography.X509Certificates;

namespace EnUzunKelimeBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir metin giriniz:");
            string metin = Console.ReadLine();

            string enUzunKelime = BulEnUzunKelime(metin);
        }

        static string BulEnUzunKelime(string text)
        {
           if(string.IsNullOrWhiteSpace(text))
           {
               Console.WriteLine("Girilen metin boş veya geçersiz.");
               return string.Empty;
           }
              string[] kelimeler = text.Split(new char[] { ' ', '.', ',', '?', '!', ';', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                string enUzunKelime = string.Empty;
                foreach (var kelime in kelimeler)
                {
                    if (kelime.Length > enUzunKelime.Length)
                    {
                        enUzunKelime = kelime;
                    }
                }
                Console.WriteLine($"En uzun kelime: {enUzunKelime} (Uzunluk: {enUzunKelime.Length})");
                return enUzunKelime;
        }
    }
}
