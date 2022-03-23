using System;
using ToDoApp.Models;

namespace ToDoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TeamMemberList.TeamList.Add(new TeamMember(1,"Ahmet"));
            TeamMemberList.TeamList.Add(new TeamMember(2,"Aylin"));
            TeamMemberList.TeamList.Add(new TeamMember(3,"Selin"));
            TeamMemberList.TeamList.Add(new TeamMember(4,"Mehmet"));
            TeamMemberList.TeamList.Add(new TeamMember(5,"Selami"));

            //Default Göre Ataması
            TodoLine.ToDoList.Add(new CardModel("c#", "c# dersi",Scale.S.ToString() ,1 ));
            TodoLine.ToDoList.Add(new CardModel("sql", "sql dersi", Scale.M.ToString(),2 ));

            //Linelar Boarda Atanıyor, yani kart oluşturuluyor
            BoardModel.BoardModels.Add("TODO Line", TodoLine.ToDoList);
            BoardModel.BoardModels.Add("IN PROGRESS Line", InProgress.InProgressList);
            BoardModel.BoardModels.Add("DONE Line", DoneLine.DoneLineList);
            bool a = false;
            while (a == false)
            {
                ToDoOperations.MainPage();
                int choose = Int32.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        ToDoOperations.ListBoard();
                        a = true;
                        break;
                    case 2:
                        ToDoOperations.AddCard();
                        a = true;
                        break;
                    case 3:
                        ToDoOperations.DeleteCard();
                        a = true;
                        break;
                    case 4:
                        ToDoOperations.TransferCard();
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