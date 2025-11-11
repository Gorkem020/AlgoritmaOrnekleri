using System;

class Program
{
    /*
           başla
           kullanıcdan terim sayısı al
           ilk terim = 0 ikinci terim = 1 olarak tanımla 
           ilk iki terimi yazdır
           3 'ten terim sayısına kadar döngü başlat
           döngü içine yeni terim tanımla ve ilk iki terimin toplamına ata
           yeni terimi yazdır
           ilk iki terimi kaydır
           bitir

       */
    static void Main(string[] args)
    {
        Console.WriteLine("ilk kaç terimi almak istersin");
        int n = Convert.ToInt32(Console.ReadLine());
        int birinciTerim = 0;
        int ikinciTerim = 1;
        Console.Write($"{birinciTerim} {ikinciTerim} ");
        for(int i =3; i<=n ; i++)
        {
            int yeniTerim = birinciTerim + ikinciTerim;
            Console.Write($"{yeniTerim} ");
            birinciTerim = ikinciTerim;
            ikinciTerim = yeniTerim;
        }
        
        

    }
}
