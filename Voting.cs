using System;

namespace VotingApp
{
    public class Voiting
    {
        private readonly Database database;

        public Voiting(Database database)
        {
            this.database = database;
        }
        public void Choise(int value)
        {
            switch (value)
            {
                case 1:
                    database.AddVoiting("Macera");
                    break;
                case 2:
                    database.AddVoiting("Aksiyon");
                    break;
                case 3:
                    database.AddVoiting("Komedi");
                    break;
                case 4:
                    database.AddVoiting("Romantik");
                    break;
                default:
                    Console.WriteLine("Hatalı Seçim.");
                    return;
            }   

            Console.WriteLine("Oy Kullanılmıştır.");
        }
    }
}
