using System.Numerics;

namespace _11.Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Abstraction is the process of simplifying
            // complex systems by breaking them into smaller,
            // more manageable parts.In OOP, abstraction
            // involves defining abstract classes, interfaces,
            // or base classes with common properties and
            // methods, leaving the specific implementation
            // details to derived classes.

            Driver driver = new Driver(new DieselCar());
            Driver driver2 = new Driver(new ElectricCar());
            Driver driver3 = new Driver(new Horse());
            driver.Start();
            driver2.Start();
            driver3.Start();

            // not DieselCar car = new DieselCar(); !!!
            IDrivable car = new DieselCar();
            car.Start();

            // if you want a default implementation use
            // an abstract class == python

            // difference between abstract class and interface
            // abstract class can have implementation
            // and a class can inherit multiple interfaces










        }
    }
}