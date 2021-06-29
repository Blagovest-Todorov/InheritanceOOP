namespace Inheritance
{
    class Student : Person, ICanRead, ICanWrite
    {
        public string School { get; set; }

        public Student(string name)
            : base(name)
        {

        }
        public Student(string name, string school)
           : this(name) // ctores are not inherited , they can be reused !
        {
            School = school;  
        }

        public void Read()
        {
            System.Console.WriteLine("I am reding");
        }

        public void Write()
        {
            throw new System.NotImplementedException();
        }
    }
}
