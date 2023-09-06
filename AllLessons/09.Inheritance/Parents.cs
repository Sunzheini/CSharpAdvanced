using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Inheritance
{
    public class Parents
    {
    }

    public class Animal
    {
        public Animal(string name) { 
            Name = name;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime LastMeal { get; set; }
    }
}
