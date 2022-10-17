using System;

namespace VotingApp
{
    public class Person
    {
        private string username;

        public Person(string username)
        {
            this.Username = username;
        }

        public string Username { get => username; set => username = value; }
    }
}
