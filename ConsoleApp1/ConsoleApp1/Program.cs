using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        
        public static void BodyguardRusvet(int rusvetOrani)
        {
            Console.WriteLine("Bodyguard rüşvet alıyor mu ? [e] = Evet, [h] = Hayır");
            string bodyguardRusvet = Console.ReadLine();

            if (bodyguardRusvet == "e")
            {
                Console.WriteLine("Ne kadar rüşvet vereceksin ?");

                int toplamOdedigim = 0;

                while (true)
                {
                    int rakam = Convert.ToInt32(Console.ReadLine());
                    toplamOdedigim = toplamOdedigim + rakam;

                    if (toplamOdedigim < rusvetOrani)
                    {
                        Console.WriteLine(toplamOdedigim + " lira ile kuş mu besliyorsun hırbo?");
                    }
                    else
                    {
                        Console.WriteLine(toplamOdedigim + " lira yeterli şimdilik. Olay çıkartma!");
                        //içeride!
                    }
                }

            }
            else if (bodyguardRusvet == "h")
            {
                throw new Exception("Mekana giremedin");
            }
        }

        public static bool KapiGirisRica()
        {
            Console.WriteLine("Kapı girişinde benimle içeri girebilecek kadın var mı ? [e] = Evet, [h] = Hayır");
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
            Console.WriteLine("Cinsiyetiniz nedir ? [e] = Erkek, [k] = Kadın");
            string gender = Console.ReadLine();
            Console.WriteLine("Yaşınız");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                BodyguardRusvet(100);
            }

            if (gender == "k")
            {
                Console.WriteLine("Kaç erkek ile geldiniz?");
                int manCount = Convert.ToInt32(Console.ReadLine());

                if (manCount > 1)
                {
                    if (KapiGirisRica())
                    {
                        Console.WriteLine("İçeride!");
                        //içerde!
                    }
                    else
                    {
                        BodyguardRusvet(50 * (manCount - 1));
                    }
                    
                }
                else
                {
                    Console.WriteLine("İçeride!");
                    //içeride!
                }
            }
            else if (gender == "e")
            {
                Console.WriteLine("Damsız girilmez.");
                Console.WriteLine("Yanınızda kadın var mı ?[e] = Evet, [h] = Hayır");
                string partyWithWomen = Console.ReadLine();

                if (partyWithWomen == "e")
                {

                }
                else if (partyWithWomen == "h")
                {
                    if (KapiGirisRica())
                    {

                    }
                    else
                    {
                        BodyguardRusvet(50);
                    }
                }
            } 






            












            //string[] fruits = new string [] { "apple", "orange", "dragon", "banana", "mango", "ananas", "unknown" } ;

            //List<string> fruitList = fruits.ToList();
            //fruitList.Add("carrot");
            //fruitList.Add("coconut");
            //fruitList.Remove("unknown");

            //string carrot = fruitList.FirstOrDefault(a => a.Equals("carrot"));
            //       carrot = fruitList.SingleOrDefault(a => a.Equals("carrot"));
            //for (int i = 0; i < fruitList.Count; i++)
            //    {
            //        string fruit = fruitList[i];
            //        Console.WriteLine(i +" : "+ fruit);
            //    }



                //IEnumerable<string> yeniList = fruitList.Where(a => a.Contains("na"));




                //for (int i = 0; i < fruitList.Count; i++)
                //{
                //    string fruit = fruitList[i];
                //    Console.WriteLine(fruit);
                //}
                //Console.WriteLine("foreach");
                //foreach ( var fruit in fruitList)
                //{
                //    Console.WriteLine(fruit);
                //}

                //fruits[1] = null;
                //Console.WriteLine(fruits[fruits.Length - 1]);

                //for (int i = 0; i < fruits.Length; i++)
                //{
                //    string fruit = fruits[i];

                //    if (fruit == "dragon")
                //    {
                //        Console.WriteLine("Dragon bulundu.");
                //        break;
                //    }

                //}

                Console.ReadLine();
        }
    }
}
