using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void BodyRusvet(int rusvetOrani)
        {
            Console.WriteLine("Bodyguard'a rüşvet alıyor mu? [E]/[H]");
            string bodyGuardRusvet = Console.ReadLine();

            if (bodyGuardRusvet == "e")
            {
                Console.WriteLine("Ne kadar rüşvet vereceksin?");

                int toplamOdedigim = 0;

                while (true)
                {
                    int rakam = Convert.ToInt32(Console.ReadLine());
                    toplamOdedigim = toplamOdedigim + rakam;

                    if (toplamOdedigim < rusvetOrani)
                    {
                        Console.WriteLine(toplamOdedigim + " ile kuş mu besliyorsun hırbo?");
                    }
                    else
                    {
                        Console.WriteLine(toplamOdedigim + " yeterli şimdilik. Olay çıkartma!");
                        //içeride!
                    }
                }
            }
            else if (bodyGuardRusvet == "h")
            {
                throw new Exception("Mekana giremedin");
            }
        }

        public static bool KapiGirisRica()
        {
            Console.WriteLine("Kapı girişinde benimle içeri girebilecek kadın var mı? [E]/[H]");
            string eH = Console.ReadLine();

            if (eH == "h")
            {
                return false;
            }
            else if (eH == "e")
            {
                return true;
            }
            else
            {
                throw new Exception("Hatalı key girişi!");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Cinsiyetiniz nedir? [E] = Erkek [K] = Kadın");
            string gender = Console.ReadLine();
            Console.WriteLine("Yaşınız?");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            { 
                BodyRusvet(100);
            }

            if (gender == "k")
            {
                Console.WriteLine("Kaç erkek ile geldiniz?");
                int manCount = Convert.ToInt32(Console.ReadLine());

                if (manCount > 1)
                {
                    if (KapiGirisRica())
                    {
                        Console.WriteLine("içeride");
                        //içeride!
                    }
                    else
                    {
                        BodyRusvet(50 * (manCount - 1));
                    }
                }
                else
                {
                    //içeride!
                }
            }
            else if (gender == "e")
            {
                Console.WriteLine("Damsız girilmez!");
                Console.WriteLine("Yanınızda kadın var mı? [E] = Evet [H] = Hayır");
                string partyWithWoman = Console.ReadLine();

                if (partyWithWoman == "e")
                {

                }
                else if (partyWithWoman == "h")
                {
                    if (KapiGirisRica())
                    {
                        //içeride!
                    }
                    else
                    {
                        BodyRusvet(50);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
