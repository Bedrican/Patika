namespace TelefonRehberi.Models
{
   
    public class PhoneModel
    {
        
        public PhoneModel(string name, string surname, string number)
        {
            this.Name = name;
            this.Surname = surname; 
            this.Number = number;
        }
        
        public string Name;
        public string Surname;
        public string Number;
    }
}