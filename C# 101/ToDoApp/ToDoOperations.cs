using ToDoApp.Models;

namespace ToDoApp
{

    public static class ToDoOperations
    {

        public static void MainPage()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Çıkmak İçin 1-5 Dışında Her Hangi Bir Şey Girmeniz Yeterlidir.");
        }
        public static string EnumToSize(int number)
        {
            if(number == 1)
            {
                return Scale.XS.ToString();
            }else if(number == 2)
            {
                return Scale.S.ToString();
            }else if(number == 3)
            {
                return Scale.M.ToString();
            }else if (number == 4)
            {
                return Scale.L.ToString();
            }
            else
            {
                return Scale.XL.ToString();
            }
        }
        public static void ListBoard()
        {
            foreach (var item in BoardModel.BoardModels)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine("************************");
                int counter = item.Value.Count;
                if (counter == 0)
                {
                    Console.WriteLine("~ BOŞ ~");
                }
                foreach (var item2 in item.Value)
                {
                    counter--;
                    Console.WriteLine("Başlık: {0}", item2.Title);
                    Console.WriteLine("İçerik: {0}", item2.Content);
                    Console.WriteLine("Atanan Kişi Numarası: {0}",item2.PersonId );
                    Console.WriteLine("Büyüklük: {0}", item2.Scale);
                    if (counter >= 1)
                    {
                        Console.WriteLine("-");
                    }
                }
            }
        }

        public static void AddCard()
        {
            Console.WriteLine("Baslik Giriniz:");
            string title = Console.ReadLine();
            Console.WriteLine("Icerik Giriniz:");
            string content = Console.ReadLine();
            Console.WriteLine("Buyukluk Seciniz -> XS(1),S(2),M(3),L(4),XL(5)");
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Kisi Seciniz:");
            UserPrint();
            int personId = Int32.Parse(Console.ReadLine());
            TodoLine.ToDoList.Add(new CardModel(title,content,EnumToSize(number),personId));
        }

        public static void DeleteCard()
        {
            Console.WriteLine(" Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine(" Lütfen kart başlığını yazınız:  ");
            string title = Console.ReadLine();
            bool isItExist = false;
            foreach (var item in BoardModel.BoardModels)
            {
                foreach (var item2 in item.Value)
                {
                    if (item2.Title == title)
                    {
                        Console.WriteLine("Kart bulundu siliniyor...");
                        item.Value.Remove(item2);
                        isItExist = true;
                        break;
                    }
                }
            }

            if (isItExist == true)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için: (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                 int check = int.Parse(Console.ReadLine());
                
            }
        }

        public static void TransferCard()
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            string title = Console.ReadLine();
            bool isItExist = false;
            foreach (var item in BoardModel.BoardModels)
            {
                foreach (var item2 in item.Value)
                {
                    if (item2.Title == title)
                    {
                        Console.WriteLine("Bulunan Kart Bilgileri:");
                        Console.WriteLine("**************************************");
                        Console.WriteLine("Başlık: {0}", item2.Title);
                        Console.WriteLine("İçerik: {0}", item2.Content);
                        Console.WriteLine("Atanan Kişi: {0}", item2.PersonId);
                        Console.WriteLine("Büyüklük: {0}", item2.Scale);
                        Console.WriteLine("Line: {0}", item.Key);
                        Console.WriteLine("Lütfen taşımak istediğiniz Line Numarasını giriniz:");
                        Console.WriteLine("(1) TODO");
                        Console.WriteLine("(2) IN PROGRESS");
                        Console.WriteLine("(3) DONE");
                        int lineNumber = int.Parse(Console.ReadLine());
                        if(lineNumber == 1)
                        {
                            TodoLine.ToDoList.Add(new CardModel(item2.Title, item2.Content,item2.Scale , item2.PersonId));
                            item.Value.Remove(item2);
                            
                            break;
                        }
                        else if(lineNumber == 2)
                        {
                            InProgress.InProgressList.Add(new CardModel(item2.Title, item2.Content, item2.Scale, item2.PersonId));
                            item.Value.Remove(item2);
                            
                            break;
                        }
                        else if (lineNumber == 3)
                        {
                            DoneLine.DoneLineList.Add(new CardModel(item2.Title, item2.Content, item2.Scale,item2.PersonId));
                            item.Value.Remove(item2);
                            
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı giriş çıkılıyor...");
                            
                            break;
                        }
                    }
                }
            }
        }

        public static void UserPrint()
        {
            Console.WriteLine("***Kişi Listesi***");
            foreach(var item in TeamMemberList.TeamList)
            {
                Console.WriteLine("Kişi Numarası: {0} , Kişi Adı: {1}", item.Id, item.UserName);
            }
            Console.WriteLine("***Kişiler Sonu***");
        }
    }
}