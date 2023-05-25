using System;

namespace SCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mounth = DateTime.Now.Month;

            // Expression
            switch (mounth)
            {
                case 1:
                Console.WriteLine("Ocak Ayındasınız");
                break;
                case 2:
                Console.WriteLine("şubat Ayındasınız");
                break;
                case 3:
                Console.WriteLine("mart Ayındasınız");
                break;
                case 4:
                Console.WriteLine("nisan Ayındasınız");
                break;
                case 5:
                Console.WriteLine("mayıs Ayındasınız");
                break;
                default:
                    Console.WriteLine("Yanlış veri girdiniz");
                    break;
            }
            switch(mounth)
            {
                case 12:
                case 1:
                case 2:
                Console.WriteLine("Kış mevsimindesiniz");
                break;
                case 3:
                case 4:
                case 5:
                Console.WriteLine("ilkbahar mevsimidesiniz");
                break;
                case 6:
                case 7:
                case 8:
                Console.WriteLine("yaz mevsimindesiniz");
                break;
                case 9:
                case 10:
                case 11:
                Console.WriteLine("sonbaharbahar mevsimidesiniz");
                break;

                default:
                break;
            }
        }
    }
}