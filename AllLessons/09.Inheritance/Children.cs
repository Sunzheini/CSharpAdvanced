using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Inheritance
{
    public class Children
    {
    }

    public class Monkey: Animal
    {
        public Monkey(string name, string tree) : base(name)
        {
            Tree = tree;
        }

        public Monkey(string name) : base(name)
        {
            Tree = "Unknown";
        }

        public string Tree { get; set; }
    }

    public class Lion: Animal
    {
        public Lion(string name) : base(name)
        {
        }
        public string Mane { get; set; }
    }

    public class Fish: Animal
    {
        public Fish(string name) : base(name)
        {
        }
        public string WaterSize { get; set; }
    }

    // --------------------------------------

    public class GoldFish: Fish
    {
        public GoldFish(string name) : base(name)
        {
        }
        public string Memory { get; set; }

        public void PrintBase()
        {
            // base is of the type Fish
            Console.WriteLine($"{this.Name}, {base.Name}");
        }
    }
}
