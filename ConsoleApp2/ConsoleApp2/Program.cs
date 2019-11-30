using System;

namespace ConsoleApp2
{
    class Program
    {
        public static void Method1()
        {
            Method2();
        }
        public static void Method2()
        {
            Method3();
        }
        public static void Method3()
        {

            int x = Convert.ToInt32("asdg");
            //kaydetme işlemi (hayali)
        }
        static void Main(string[] args)
        {
            try
            {
                Method1();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            

            Console.WriteLine("Lütfen bir sayı giriniz.");
            string kullanicidanGelenDeger = Console.ReadLine();
            int sayi = 0;
            try
            {
                 sayi = Convert.ToInt32(kullanicidanGelenDeger);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


            int.TryParse(kullanicidanGelenDeger, out int sayix);
            

            Console.WriteLine("Kullanıcıdan gelen sayı: " + sayi);


            Console.ReadLine();
        }
    }
}
