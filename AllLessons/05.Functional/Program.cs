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

            // Lambda
            // ------------------------------------------------------

            // lambda: when want to use a function only once
            // var evenList = list.Where((int x) => x % 2 == 0);
            var list = new List<int> { 1, 2, 3, 4, 5 };
            // var evenList1 = list.Where((int x) => x % 2 == 0);
            var evenList2 = list.Where((int x) =>
            {
                if (x % 2 == 0)
                {
                    return true;
                }
                return false;
            });
            var evenList3 = list.Where(IsEven); // same as above
            Console.WriteLine(String.Join(", ", evenList2));

            // Actions and Funcs
            // ------------------------------------------------------
            // assignment to a variable
            // when void --> type is Action
            Action lambda = () => Console.WriteLine("Hello, World!");
            lambda();

            // when return value --> type is Func
            Func<int> lambda2 = () => 5 + 5;    // <return>
            Func<int, int> lambda3 = (int x) => x + 5; // <arg, return>
            lambda3(5);

            // different ways to write lambda
            //int[] numbers = Console.ReadLine().Split()
            //.Select(int.Parse).ToArray();
            //int[] numbers = Console.ReadLine().Split()
            //.Select(x => int.Parse(x)).ToArray();
            //int[] numbers = Console.ReadLine().Split()
            //    .Select((string x) =>
            //    {
            //        return int.Parse(x);
            //    }).ToArray();

            // Predicates: like Func but return bool
            // ------------------------------------------------------
            Func<int, bool> funcFilter = IsEvenFilter;
            Predicate<int> predicateFilter = IsEvenFilter; // same as above

            // Delegates: short funcs!
            // ------------------------------------------------------
        }
        Predicate<int> pred = FilterByAge;
        Func<int, bool> func = FilterByAge;
        FilterDelegate del = FilterByAge;

        static bool IsEven(int x)
        {
            if (x % 2 == 0)
            {
                return true;
            }
            return false;
        }

        // Func: can pass functions as arguments
        static int Multiply(int x, int y)
        {
            return x * y;
        }

        // Higher-Order Function: takes a function as an argument
        static int Operation(Func<int, int, int> myFunc, int x, int y)
        {
            return myFunc(x, y);
        }

        // Predicates
        static bool IsEvenFilter(int x)
        {
            return x % 2 == 0;
        }

        // Delegates
        static bool FilterByAge(int age)
        {
            if (age < 21)
            {
                return false;
            }
            return true;
        }

        delegate bool FilterDelegate(int input);
    }
}
