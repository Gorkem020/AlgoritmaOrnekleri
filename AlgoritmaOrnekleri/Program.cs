namespace AlgoritmaOrnekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Faktöriyel hesaplayan algoritması
            /* 1. BASLA
               2. Sayı giriniz(number)
               3. factor = 1
               4. Eğer number < 0, Evet ise 'number negatif sayı olamaz' yazdır ve 11.adıma git
               5. Eğer number = 0, Evet ise 10.adıma git
               6. factor = factor * number
               7. number = number - 1
               8. Eğer number = 0, Evet ise 8.adıma git
               9. Hayır ise 4.adıma git
               10. factor yazdır
               11. BİTİR  */

            Console.WriteLine("Faktöriyel hesaplama programına hoşgeldiniz!");
            Console.Write("Lütfen bir sayı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int factor = 1;

            if (number < 0)
            {
                Console.WriteLine("Negatif sayıların faktöriyeli hesaplanamaz.");
                return;
            }
            else if (number == 0)
            {
                Console.WriteLine("0! = 1'dir.");
                return;
            }

            for (int i = number; i > 0; i--)
            {
                factor *= i;
            }

            Console.WriteLine($"{number}! = {factor}");
        }
    }
}
