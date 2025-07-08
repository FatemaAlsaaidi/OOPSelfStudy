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

        public Person(string name, int age, string phoneNumber)
        {
            Name = name;
            Age = age;
            PhoneNumber = phoneNumber;

            Console.WriteLine("Person success added");
        }
    }

    
}
