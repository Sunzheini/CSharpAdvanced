namespace _06.Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course()
            {
                Name = "C# Advanced",
                Lecturer = "Viktor",
                NumberOfStudents = 20
            };
            Student student = new Student()
            {
                FirstName = "Pesho",
                LastName = "Petrov",
                Age = 20,
                Courses = new List<Course>()
                {
                    course
                }
            };
            //student.Print();
            
            //PrintStudent(student);

            static void PrintStudent(Student student)
            {
                Console.WriteLine($"" +
                    $"{student.FirstName} " +
                    $"{student.LastName}: " +
                    $"{student.Age}" +
                    $"{student.Courses[0].Name}");
            }

            Car car = new Car("BMW", "X5", 2010);
            Console.WriteLine($"{car.Make} {car.Model} {car.Year}");

            // Enumerations: when you want to have a fixed set of values
            // --------------------------------------------------------
            CarType carTypeEnum = CarType.Sedan;
            carTypeEnum = 
                (CarType)Enum.Parse(typeof(CarType), Console.ReadLine());

            Console.WriteLine(carTypeEnum);         // Sedan
            Console.WriteLine((int)carTypeEnum);    // 0

            if (carTypeEnum == CarType.Sedan)
            {
                Console.WriteLine("It is a sedan!");
            }

            // static methods
            // --------------
            Console.WriteLine(Calculator.Add(1, 2));

            // static classes: cannot be instantiated
            // --------------

            // namespaces
            // --------------
            // organize classes in libraries
        }
    }

    public class Student
    {
        // field should be private by default and should be private
        int fieldAge;

        // properties
        public int FieldAge
        {
            get
            {
                return this.fieldAge;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative!");
                }
                this.fieldAge = value;
            }
        }
        // custom properties
        public string MofidiedAge
        {
            get
            {
                return $"Modified age: {this.fieldAge + 2}";
            }
        }

        // auto properties, firstName is created!
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Course> Courses { get; set; }

        // methods
        // instance method: the `Print` method of the instance
        public void Print()
        {         
            Console.WriteLine($"Name: {this.FirstName} {this.LastName}");
        }

        public void PrintFieldAge()
        {
            Console.WriteLine($"Field age: {this.fieldAge}");
        }
    }

    public class Course
    {
        public string Name { get; set; }
        public string Lecturer { get; set; }
        public int NumberOfStudents { get; set; }
    }

    // constructors
    public class Car
    {
        // can overload to have also an empty with default field values
        // shortcut: ctor + tab + tab
        public Car()
        {
            Make = "BMW";
            Model = "X5";
            Year = 2010;
        }

        // first call the empty constructor and then the one with parameters
        public Car(string make, string model, int year): this()
        {
            Make = make;
            Model = model;
            Year = year;
        }

        // chaining constructors
        public Car(string make, string model, int year, int fuel): 
            this(make, model, year)
        {
            Fuel = fuel;
        }

        // sortcut: select the fields and ctrl + . -> generate constructor
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Fuel { get; set; }
    }

    // Enumerations
    public enum CarType
    {
        Sedan,
        Coupe,
        Hatchback,
        SUV
    }

    // static methods
    public class Calculator
    {
        public int SomeProp { get; set; }

        // static method == staticmethod in python, can be called without
        public static int Add(int a, int b)
        {
            //return a + b + SomeProp; // no access to instance fields!
            return a + b;
        }
    }

    // static classes: inside only static methods!
    public static class CalculatorStatic
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
