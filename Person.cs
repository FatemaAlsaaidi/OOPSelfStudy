using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSelfStudy
{
    class Person
    {
        // Create a fields
        public int Id;
        public string Name;
        public int Age;
        public string PhoneNumber;
        public string career;

        // Parameterized constructor 
        public Person(string name, int age, string phoneNumber)
        {
            Name = name;
            Age = age;
            PhoneNumber = phoneNumber;
            Id = new Random().Next(1000, 9999); // Random ID generation
            career = "Unemployed"; // Default career value
            Console.WriteLine("Person success added with ID: " + Id);


        }

        // Copy constructor 
        public Person(Person person)
        {
            Id = person.Id;
            Name = person.Name;
            Age = person.Age;
            PhoneNumber = person.PhoneNumber;
            career = person.career;
            Console.WriteLine("Person copy success added");
        }

        // Static constructore
        static Person()
        {
            Id = 0;
            Name = "Unknown";
            Age = 0;
            PhoneNumber = "000-000-0000";
            career = "Unemployed"; // Default career value
            Console.WriteLine("Default person created with ID: " + Id);

        }
    }


}
