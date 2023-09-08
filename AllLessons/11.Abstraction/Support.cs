using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Abstraction
{
    internal class Support
    {
    }

    public class DieselCar : IDrivable
    {
        public void Start()
        {
            Console.WriteLine("Diesel car started");
        }

        public void Accelerate()
        {
            Console.WriteLine("Diesel car accelerated");
            this.Speed += 10;
        }

        public void Brake()
        {
            Console.WriteLine("Diesel car stopped");
            this.Speed -= 10;
        }

        public int Speed { get; set; }
    }

    public class ElectricCar : IDrivable
    {
        public void Start()
        {
            Console.WriteLine("ElectricCar started");
        }

        public void Accelerate()
        {
            Console.WriteLine("ElectricCar accelerated");
            this.Speed += 20;
        }

        public void Brake()
        {
            Console.WriteLine("ElectricCar stopped");
            this.Speed -= 20;
        }

        public int Speed { get; set; }
    }

    public class Horse : IDrivable
    {
        public int Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Accelerate()
        {
            Console.WriteLine("Horse going faster");
        }

        public void Brake()
        {
            Console.WriteLine("Horse going slower");
        }

        public void Start()
        {
            Console.WriteLine("Mounting Horse");
        }
    }

    public class Driver
    {
        private IDrivable drivable;

        public Driver(IDrivable car)
        {
            this.drivable = car;
        }

        public void Start()
        {
            Console.WriteLine("Start button clicked");
            this.drivable.Start();
        }

        public void Accelerate()
        {
            Console.WriteLine("Accelerate button clicked");
            this.drivable.Accelerate();
        }

        public void Brake()
        {
            Console.WriteLine("Brake button clicked");
            this.drivable.Brake();
        }
    }


}
