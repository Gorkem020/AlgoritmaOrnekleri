namespace CumleDuzenle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir cümle giriniz:");
            string cumle = Console.ReadLine();

            var result = CapitalizeSentence(cumle);

            Console.WriteLine("Yeni Cümle:");
            Console.WriteLine(result);
        }

        static string CapitalizeSentence(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
                return sentence;
            string[] words = sentence.Split(new char[] { ' ', '.',',','?','!',';' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i]))
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }
            Console.WriteLine(words.Length);
            return string.Join(" ", words);
        }
    }
}
