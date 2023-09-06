using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Inheritance
{
    internal class Visibility
    {
    }

    // --------------------------------------------------
    // Visibility of the fields of the base class
    // private: not inherited and seen only in the base class
    // protected: inherited and seen in base class and children
    // internal: inherited and seen by all in the project / namespace
    // public: inherited and seen by all
    class AnimalVisibility
    {
        private int privateField = 1;
        protected int protectedField = 2;
        internal int internalField = 3;
        public int publicField = 4;

        // Sleep() uses privateField and is used in the child class!
        public void Sleep()
        {
            Console.WriteLine($"Sleep time: {privateField}");
        }
    }

    class  LionVisibility : AnimalVisibility
    {
        public void Printer()
        {
            // Console.WriteLine(privateField); // cant access private
            Console.WriteLine(protectedField);
            Console.WriteLine(internalField);
            Console.WriteLine(publicField);
        }
    }
}
