namespace IkiTarihArasindakiFark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             1.Basla
             2.Başlangıç ve bitiş adında iki tarih değişkeni tanımla
             3.Bitiştten başlangıç tarihini çıkar ve gün sayısı adında bir değişkene ata
             4.Gün sayısı değişkenini ekrana yazdır
             5.Bitir
             */

            DateTime baslangic = new DateTime(2024,3,20);
            DateTime bitis = DateTime.Now;

            int gunSayisi = (bitis - baslangic).Days;
            Console.WriteLine($"İki tarih arasındaki gün sayısı : {gunSayisi}");

        }
    }
}
