namespace enKucukSayininIndisiiBulma
{
    internal class Program
    {
        /*
   bir dizi oluştur
   dizinin 0.elemanını en küçük olarak bir değişkene ata
   indis değeri oluştur ve 0 olarak ata
   dizi uznluğu kadar bir döngü oluştur
   her döngüde dizinin i. elemanı min numberdan küçükmü kontorl et 
   küçük ise minnumberı dizinin i. değerine eşitle
   indisi i değerine eşitle
   değilse devam et
   döngü sonunda aldığın indis değeirni ve değeri yazdır
      */
        static void Main(string[] args)
        {
            int[] array = { 5, 234, 23, 132, 3, 23, 43, 1, 2344, 1 };
            int minNumber = array[0];
            int indis = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (minNumber > array[i])
                {
                    minNumber = array[i];
                    indis = i;

                }

            }
            for (int i = 0; i < array.Length; i++)
            {
                if (minNumber == array[i])
                {
                    Console.WriteLine($"en küçük elemanın indisi -> {i}, en küçük eleman ->{minNumber}, ");


                }
            }


        }
    }
}
