using System.Text.RegularExpressions;

namespace SifreOlusturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("İsim: ");
            string firstName = Console.ReadLine()?.Trim() ?? "";

            Console.Write("Soyisim: ");
            string lastName = Console.ReadLine()?.Trim() ?? "";

            Console.Write("Doğum tarihi: ");
            string birthInput = Console.ReadLine()?.Trim() ?? "";

            string password = CreatePassword(firstName, lastName, birthInput);

            Console.WriteLine($"\nOluşturulan şifre: {password}");
            Console.WriteLine("Çıkmak için bir tuşa basın...");
            Console.ReadKey();
        }

        static string CreatePassword(string firstName, string lastName, string birthInput)
        {
            // İlk 2 harf (büyük)
            string firstPart;
            if (string.IsNullOrEmpty(firstName))
                firstPart = "??";
            else if (firstName.Length >= 2)
                firstPart = firstName.Substring(0, 2).ToUpper();
            else
                firstPart = firstName.ToUpper(); // 1 harf varsa onu al

            // Soyisim son 2 harf (küçük)
            string lastPart;
            if (string.IsNullOrEmpty(lastName))
                lastPart = "??";
            else if (lastName.Length >= 2)
                lastPart = lastName.Substring(lastName.Length - 2, 2).ToLower();
            else
                lastPart = lastName.ToLower(); // 1 harf varsa onu al

            // Doğum tarihinin son iki rakamı (öncelikle DateTime olarak parse etmeye çalış)
            string yearTwoDigits = ExtractLastTwoDigitsOfYear(birthInput);

            return $"{firstPart}{lastPart}{yearTwoDigits}";
        }

        static string ExtractLastTwoDigitsOfYear(string birthInput)
        {
            if (string.IsNullOrWhiteSpace(birthInput))
                return "00";

            // 1) DateTime olarak parse etmeye çalış
            if (DateTime.TryParse(birthInput, out DateTime dt))
            {
                return (dt.Year % 100).ToString("D2"); // örn. 1990 -> "90", 2005 -> "05"
            }

            // 2) Eğer parse edilemediyse, string içindeki rakamlardan son iki rakamı al
            // (ör. "1990", "90", "12/05/1990" gibi karma formlar için)
            var digits = Regex.Matches(birthInput, @"\d")
                              .Cast<Match>()
                              .Select(m => m.Value)
                              .ToArray();

            if (digits.Length == 0)
                return "00";

            // Tüm rakamları birleştir ve sondan iki karakter al
            string allDigits = string.Concat(digits); // örn "12051990" veya "1990" veya "90"
            if (allDigits.Length >= 2)
            {
                string lastTwo = allDigits.Substring(allDigits.Length - 2, 2);
                return lastTwo;
            }

            // Eğer tek rakam varsa başına 0 ekle
            return allDigits.PadLeft(2, '0');
        }
    }
}