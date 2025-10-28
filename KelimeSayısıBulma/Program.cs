/*Bir metin dizisi alın ve bu metinde kaç tane kelime olduğunu hesaplayan bir algoritma
yazın.

1)Başla
2)Kullanıcıdan bir metin al
3)Metni metin adında bir değişkene ata
4)metin değişkenini split metoduyla ayır ve kelimeler adında yeni bir diziye ata
5)dizinin uzunluğunu yazdır
6)bitir
*/

Console.WriteLine("bir metin giriniz");
string metin = Console.ReadLine();

string[] kelimeler = metin.Split(" ",StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine($"kelime sayısı: {kelimeler.Length}");

