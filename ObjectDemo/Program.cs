using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Fredrik");
            
            p1.PrintPerson();

            Person p2 = new Person("Sandra");
            p2.Name = "Sandra Kristina";
            p2.PrintPerson();

            p1 = null;
        }
    }
}
