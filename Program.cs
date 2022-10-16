using System;

namespace VotingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            
            while (true)
            {
                Console.WriteLine("Kullanıcı Adınızı Giriniz: ");
                string userName = Console.ReadLine();
                
                if(!database.UserCheck(userName))
                {
                    Console.WriteLine("Kullanıcı Bulunamadı Yeni Kayıt Oluşturuluyor: ");
                    Person newPerson = new Person(userName);
                    database.AddUser(newPerson);
                }
            
                Voiting toVoit = new Voiting(database);

                Console.WriteLine("Oylamaya Katılın");
                Console.WriteLine("**********************");
                Console.WriteLine("Macera İçin ---> (1)");
                Console.WriteLine("Aksiyon İçin ---> (2)");
                Console.WriteLine("Komedi İçin ---> (3)");
                Console.WriteLine("Romantik İçin ---> (4)");

                int choise = Convert.ToInt32(Console.ReadLine());
                toVoit.Choise(choise);

                Console.WriteLine("Güncel Sonuçlar :");
                foreach (var item in database.GetVoitingResult())
                {
                    Console.WriteLine($"{item.Key} kategorisi {item.Value} oy almıştır.");
                }
            }
        }
    }
}