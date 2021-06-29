namespace Inheritance
{
    class Employee :  Person
    {
        public string Company { get; set; }
        public Employee(string name)
            : base(name)
        {

        }
    }
}
