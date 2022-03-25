using System;
using System.Collections.Generic;
using System.Text;

namespace martclass
{
    class Person
    {
        public Person(string name,string surname,int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            if (age < 18)
            {
                Console.WriteLine("Islemek ucun min yas 18 olmalidir");
            }

        }
        public string Name;
        public string Surname;
        public int Age;

    }
}
