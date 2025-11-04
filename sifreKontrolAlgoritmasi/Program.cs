namespace sifreKontrolAlgoritmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* şifreyi kabul edebilmesi için 8 karaktere eşit veya büyük olması gerekmektedir
             * büyük harf, küçük harf ve rakam içermesi gerekmektedir
             * özel karakter içermelidir
             */

            do
            {
                Console.WriteLine("Şifre oluşturunuz");
                string password = Console.ReadLine();

                if (password.Length < 8)
                {
                    Console.WriteLine("şifrenizin 8 veya daha fazla karakter olması gerekmektedir");
                    continue;
                }
                bool hasUpper = false;
                bool hasLower = false;
                bool hasDigit = false;
                bool hasSpecial = false;

                for (int i = 0; i< password.Length; i++)
                {
                    if (password[i]>= 'A' && password[i]<= 'Z')
                    {
                        hasUpper = true;

                    }else if(password[i]>= 'a' && password[i]<= 'z')
                    {
                        hasLower = true;

                    }else if (password[i]>= '0' && password[i] <= '9')
                    {
                        hasDigit = true;
                    }
                    else
                    {
                        hasSpecial = true;
                    }
                }

                if( hasUpper && hasLower && hasDigit && hasSpecial)
                {
                    Console.WriteLine($"şifreniz başarılı şekilde oluşturuldu, şifreniz : {password}");
                    break;
                
                }else
                {
                    Console.WriteLine("şifrenizin 8 veya daha fazla karakter, en az bir büyük harf, bir küçük harf, bir özel karakter ve bir rakam içermesi gerekmektedir");
                }

            } while (true);

            
            
        }
    
    }
}
