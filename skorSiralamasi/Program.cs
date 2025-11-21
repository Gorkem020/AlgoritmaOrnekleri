namespace skorSiralamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Mustafa her gün zorlu bir oyun oynamayı seviyor ve skorunu geliştirmek için her zaman hevesli. Her gün oyunun sonunda aldığı puanı kaydediyor. Mustafa, her günkü skorunu geçebilmesi için kaç gün beklemesi gerektiğini merak ediyor.

               Size, scores[i] değerinin Mustafa’nın i. gündeki skorunu temsil ettiği bir dizi veriliyor. Her gün için, Mustafa’nın daha yüksek bir skor elde edebilmesi için kaç gün beklemesi gerektiğini belirleyin. Eğer gelecekte daha yüksek bir skorun olmadığı bir gün varsa, o günün sonucu 0 olmalıdır.
           
             
             */
            Console.Write("Gün sayısını girin (N): ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Günlük skorları boşlukla ayrılmış şekilde girin: ");
            int[] scores = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int[] result = new int[N];

            for (int i = 0; i < N; i++)
            {
                int wait = 0;
                for (int j = i + 1; j < N; j++)
                {
                    if (scores[j] > scores[i])
                    {
                        wait = j - i;
                        break;
                    }
                }
                result[i] = wait;
            }

            Console.WriteLine("Sonuç: " + string.Join(" ", result));
        }
    }
}
