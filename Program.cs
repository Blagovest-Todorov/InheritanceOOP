namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Pesho");
            var student = new Student("Gosho", "6ToPomoshtno");
            var employee = new Employee("Niki");

            person.Sleep();
            student.Sleep();
            employee.Sleep();

            // no multiple inheritance in C# , only single inheritance in C#.  one class can inherit one;
            //  Inheritance -ability derived child class to inherits , extends the base class members, with
            //  given limitations
            //  //multiple interfaces can be implemented

            student.Read();
        }
    }
}
