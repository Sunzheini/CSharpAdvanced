namespace _12.Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism: take the forms of whatever
            // is inherited from.
            object personObject = new Person();
            Mammal personMammal = new Person();
            IAnimal personAnimal = new Person();
            Person person = new Person();

            // personObject.NickName = "John"; // Error
            // need to cast to Person to access NickName
            ((Person)personObject).NickName = "John";

            // only have access to Age
            ((Person)personMammal).NickName = "John";

            // can use everything
            Person person1 = (Person)personAnimal;

            // is operator
            // ---------------------------------------
            // if personObject is of type Person
            if (personObject is Person person2) 
            {
                person2.NickName = "John";
            }

            // part2
            // ---------------------------------------
            List<Part2Animal> zoo = new List<Part2Animal>();
            zoo.Add(new Dog());

            // as operator: safe casting!
            // ---------------------------------------
            Part2Animal dog = new Dog();
            // if dog is a Dog, return a Dog, if not: null
            Dog dog2 = dog as Dog;  

            // if dog is a Dog, return a Dog, if not: exception
            Dog dog3 = (Dog)dog;

            // ---------------------------------------
            // compile time polimorphism: method overloading

            // ---------------------------------------
            // runtime polimorphism: method overriding


        }
    }

    public class Person : Mammal, IAnimal
    {
        public string NickName { get; set; }
    }

    public interface IAnimal
    {
    }

    public class Mammal
    {
        public int Age { get; set; }
    }
}
