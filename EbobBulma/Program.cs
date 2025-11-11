namespace EbobBulma
{
    internal class Program
    {
        /*
         1.Başla
         2.Kullanıcıdan iki pozitif tam sayı al
         3.İlk sayıyı "a", ikinci sayıyı "b" olarak ata
         4.ilk sayı kadar bir döngü oluştur ve kalanı 0 olan tüm sayıları ebob değişkenine ekle
         5.İkinci sayı kadar bir döngü oluştur ve kalanı 0 olan tüm sayıları ebob listesine ekle
         6.ebob listesini yazdır.
         7.Bitir
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen ilk sayıyı giriniz:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen ikinci sayıyı giriniz:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int ebob = 0;
            int min = (number1 < number2) ? number1 : number2;

            if (number1 > 0 && number2 > 0)
            {
                for (int i = 1; i <= min; i++)
                {
                    if(number1 % i == 0 && number2 % i == 0)
                    {
                        if (i > ebob)
                        {
                            ebob = i;
                        }
                    }
                }
            } 
            int ekok = (number1 * number2) / ebob;
            Console.WriteLine("Ebob: " + ebob);
            Console.WriteLine("Ekok: " + ekok);
        }
    }
}
