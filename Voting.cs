using System;

namespace VotingApp
{
    public class Voiting
    {
        private readonly Database database;

        private int MaceraCount = 0, AksiyonCount = 0, KomediCount = 0, RomantikCount = 0;

        public Voiting(Database database)
        {
            this.database = database;
        }
        public void Choise(int value)
        {
            switch (value)
            {
                case 1:
                    MaceraCount++;
                    database.AddVoiting("Macera", MaceraCount);
                    Console.WriteLine("Oy Kullanılmıştır.");
                    break;
                case 2:
                    AksiyonCount++;
                    database.AddVoiting("Aksiyon", AksiyonCount);
                    Console.WriteLine("Oy Kullanılmıştır.");
                    break;
                case 3:
                    KomediCount++;
                    database.AddVoiting("Komedi", KomediCount);
                    Console.WriteLine("Oy Kullanılmıştır.");
                    break;
                case 4:
                    RomantikCount++;
                    database.AddVoiting("Romantik", RomantikCount);
                    Console.WriteLine("Oy Kullanılmıştır.");
                    break;
                default:
                    Console.WriteLine("Hatalı Seçim.");
                    break;
            }        
        }
    }
}
