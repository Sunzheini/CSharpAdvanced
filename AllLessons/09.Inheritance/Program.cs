namespace _09.Inheritance
{
    internal class Program
    {
        // you can inherit only 1 class from another!
        static void Main(string[] args)
        {
            Lion lion = new Lion("Simba");
            lion.Mane = "Long";
            lion.Age = 3;
            lion.LastMeal = DateTime.Now;
            Console.WriteLine($"{lion.Name}," +
                $"{lion.Age}, {lion.Mane}" +
                $"{lion.LastMeal}");

            // --------------------------------------------------
            // constructors cant be inherited, but can be reused
            // first the base class constructor is called
            // : base == super in python

            // --------------------------------------------------
            // if child class redefines fields, methods it overrides the inherited
            // but with base.Name you access the base class fields / methods

            // --------------------------------------------------
            // virtual methods can be overriden in the child class
            // if you want to prevent this use the sealed keyword
            // mostly used for the methods
        }
    }
}
