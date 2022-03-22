using System;
using TelefonRehberi.Models;

namespace TelefonRehberi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = false;
            PhoneListModel.PhoneNumberList.Add(new PhoneModel("Bedrican", "Caliskan", "123"));
            PhoneListModel.PhoneNumberList.Add(new PhoneModel("Ender", "Sunal", "456"));
            PhoneListModel.PhoneNumberList.Add(new PhoneModel("Mert", "Babur", "789"));
            PhoneListModel.PhoneNumberList.Add(new PhoneModel("Bertay", "Eren", "123"));
            PhoneListModel.PhoneNumberList.Add(new PhoneModel("Umut", "Temes", "852"));
            while (a == false)
            {
                NumberOperations.MainPage();
                int choose = Int32.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        NumberOperations.SaveNumber();
                        a = true;
                        break;
                    case 2:
                        NumberOperations.DeleteNumber();
                        a = true;
                        break;
                    case 3:
                        NumberOperations.UpdateNumber();
                        a = true;
                        break;
                    case 4:
                        NumberOperations.PrintNumberList();
                        a = true;
                        break;
                    case 5:
                        NumberOperations.SearchNumber();
                        a = true;
                        break;
                    default:
                        Console.WriteLine("1-5 Aralığı Dışında Bir Sayı Girildi, Çıkılıyor...");
                        break;
                }
            }
            
        }
    }
}