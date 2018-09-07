using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDemo
{
    class Person
    {
        // Fields => variabler

        private string name;
        private int _age;

        // Properties

        public string Name
        {
            // public string getName()
            get
            {
                return name;
            }

            // public void setName(string value)
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Namn får inte vara tomt");
                }
                name = value;
            }
        }

        public int Age { get => _age; set => _age = value; }

        public int ShowSize { get; set; }

        // Constructor

        public Person(string name)
        {
            Name = name;
        }

        // Methods

        public void PrintPerson()
        {
            Console.WriteLine("Person");
            Console.WriteLine("Name: " + this.Name);
        }
    }
}
