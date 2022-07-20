using System;

namespace hata_yönetimi
{
    class Program
    {
        static void Main(string[] args)
        {   
            try
            {
            Console.WriteLine("bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmiş olduğunuz sayı :" + sayi);
            
            }
            catch(Exception ex)
            {   
                Console.WriteLine("Hata: "+ ex.Message.ToString());

            }
            finally
            {
                Console.WriteLine("işlem tamamlandı");
                
            }
        }   
    }
}