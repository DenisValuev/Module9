namespace Module9.Unit4
{
    class Car 
    {
        public string Model { get; set; }
    }
    class Lexus : Car { }
    class Parent 
    {
        public string Name { get; set; }
    }
    class Child : Parent { }
    internal class Program
    {
        public delegate Car CarDelegate(string name);
        public delegate void ChildInfo(Child child);
        static void Main(string[] args)
        {
            CarDelegate carDelegate;
            carDelegate = BuildLexus;
            Car c = carDelegate("GX460");
            Console.WriteLine(c.Model);

            ChildInfo childInfo = GetParentInfo;
            Child child = new Child
            {
                Name = "Nikita"
            };
            childInfo(child);

        }
        static Lexus BuildLexus(string model)
        {
            return new Lexus { Model = model };
        }
        static void GetParentInfo( Parent p)
        {
            Console.WriteLine(p.Name);
        }
    }
}
