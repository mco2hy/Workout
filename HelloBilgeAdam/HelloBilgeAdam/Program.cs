using System;

namespace HelloBilgeAdam
{
    class Program
    {
        static void Main(string[] args)
        {

            int result = 0;

            while (true)
            {
                Console.WriteLine("Toplamak istediğiniz değeri giriniz. ");

                string value = Console.ReadLine();
                int numericValue = Convert.ToInt32(value);

                result = result + numericValue;
                if (result > 100 && (result + 50 ) == 200)
                {
                    Console.WriteLine("Değer + 50 = 200 eşit");
                }

                if (result == 50 || result == 0 || result == 1 && result <10)
                {
                    Console.WriteLine("Sonuç 50 veya 0 veya sonuç 10 dan küçük ve 1 ise");
                }

                Console.WriteLine("Toplam: " + result);
            }

            Console.ReadLine();
        }

        public static int ToplaYazdir(int a, int b)
        {
            int toplam = a + b;

            return toplam;
        }

        public static int CikartYazdir(int a, int b)
        {
            int sonuc = a - b;

            return sonuc;
        }
    }
}
