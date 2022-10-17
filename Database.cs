using System;

namespace VotingApp
{
    public class Database
    {
        private List<Person> personList;
        private static Dictionary<string, int> voitingResult = new Dictionary<string, int>();
        
        public Database()
        {
            personList = new List<Person>()
            {
                new Person("ugur"),
                new Person("ahmet"),
                new Person("ayşe"),
                new Person("veli"),
                new Person("ilker")
            };
        }
        public bool UserCheck(string username)
        {
            foreach (var item in personList)
            {
                if(item.Username == username)
                {
                    return true;
                }
            }
            return false;
        }
        public void AddUser(Person person)
        {
            personList.Add(person);
            Console.WriteLine("Kayıt oluşturuldu.");
        }
        public void AddVoiting(string key)
        {
            if (voitingResult.ContainsKey(key) == false)
            {
                voitingResult.Add(key, 1);
                return;
            }
            voitingResult[key]++;
        }
        public Dictionary<string, int> GetVoitingResult()
        {
            return voitingResult;
        }
    }
}