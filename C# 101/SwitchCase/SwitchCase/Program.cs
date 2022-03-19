using System;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Month = DateTime.Now.Month;

            switch (Month)
            {
                case 1:
                    System.Console.WriteLine("Ocak Ayındasınız!");
                    break;
                case 2:
                    System.Console.WriteLine("Şubat Ayındasınız!");
                    break;
                case 3:
                    System.Console.WriteLine("Mart Ayındasınız!");
                    break;

                default:
                    System.Console.WriteLine("Yanlış veri girdiniz!");
                    break;
            }

            switch (Month)
            {
                case 12:
                case 1:
                case 2:
                    System.Console.WriteLine("Kış ayındasınız!");
                    break;
                case 3:
                case 4:
                case 5:
                    System.Console.WriteLine("İlkbahar ayındasınız!");
                    break;
                case 6:
                case 7:
                case 8:
                    System.Console.WriteLine("Yaz ayındasınız!");
                    break;
                case 9:
                case 10:
                case 11:
                    System.Console.WriteLine("Sonbahar ayındasınız!");
                    break;
                default:
                    break;
            }
        }
    }
}