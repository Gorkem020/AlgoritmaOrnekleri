namespace istenilenHarfiMetindeBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1.BASLA
             * 2.Kullanıcıdan cümleyi al
             * 3.Kullanıcıdan harfi al
             * 4. Harfin cümledeki ilk geçtiği yeri bul
             * 5.Harften öncesini al
             * 6. Ekrana yazdır
             * 7. Bitir
             * 
             */

            Console.Write("Bir cümle girin: ");
            string cumle = Console.ReadLine().ToLower();
            
            Console.Write("Bir harf girin: ");
            char harf = Console.ReadKey().KeyChar;
            harf = char.ToLower(harf);

            Console.WriteLine(); 
           
            int index = cumle.IndexOf(harf);

            if (index != -1)
            {
                
                string sonuc = cumle.Substring(0, index+1);
                Console.WriteLine("Sonuç: " + sonuc);
            }
            else
            {
                Console.WriteLine("Girilen harf cümlede bulunamadı.");
            }
        }
    }
}
