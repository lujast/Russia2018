using System;

namespace Russia2018.Domain
{
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NickName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Country CountryOfBirth { get; set; }

    }
}