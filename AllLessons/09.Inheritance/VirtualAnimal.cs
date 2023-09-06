using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Inheritance
{
    internal class VirtualAnimal
    {
        // virtual methods can be overriden in the child class
        public virtual void Eat()
        {
            Console.WriteLine("Eating");
        }
    }

    internal class VirtualLion : VirtualAnimal
    {
        // override the Eat() method
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("Everything");
        }

        public override string ToString()
        {
            // return base.ToString();
            return $"New string";
        }
    }
}
