using System;

namespace Inheritance
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }        

        public Person(string name)
        {
            Name = name;
        }
        public void Sleep() 
        {
            Console.WriteLine($"I am an {this} sleeping"); 
        }
    }
}
