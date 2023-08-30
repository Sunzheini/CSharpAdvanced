using System.Linq;

namespace _05.Functional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // 1. same output for same input
            // 2. methods dont change anything outside of their scope

            // lambda expressions
            var list = new List<int> { 1, 2, 3, 4, 5 };
            var evenList = list.Where((x) => x % 2 == 0);
            Console.WriteLine(String.Join(", ", evenList));

        }


    }
}
