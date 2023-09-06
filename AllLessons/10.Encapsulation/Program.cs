namespace _10.Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hide the unnecessary details from the outside world.
            // what is exposed is called contract
            // what is hidden is called implementation
            // also useful for future changes

            Kitchen kitchen = new Kitchen();
            kitchen.CookTheSpaggetti();

            // ----------------------------------------------------
            // Access modifiers

            //private - only the class itself can access it
            //protected - only the class itself and its children can access it
            //internal - only the classes in the same project can access it
            //public - everyone can access it (between projects)

            // classes should be internal or public

            // ----------------------------------------------------
            // Project references

            // right click on the project -> add -> reference
            // add the project you want to reference
            // you can now use the classes from the referenced project

            // you can also add a reference to the .dll!
            // using Namespace; --> then you can now use the classes
        }
    }

    public class Kitchen 
    {
        // make these private
        private int spaggettiCount;
        private int meatCount;
        private int tomatoSauceCount;
        private int baconCount;
        private int bechamelCount;

        public void CookTheSpaggetti()
        {
            this.TakeSpaggetti(200);
            this.BoilWater();
            this.AddSpaggettiToWater();
            this.PutMeatInTigan();
            this.AddSauceToMeat();
            this.PutSpaggetiAndSauceInTheDish();
            this.PutMeatInTigan();
            this.AddSauceToMeat();
            this.PutSpaggetiAndSauceInTheDish();
        }

        private void TakeSpaggetti(int grams)
        {
            Console.WriteLine($"Take {grams} of spaggetti");
        }

        private void BoilWater()
        {
            Console.WriteLine("Boil water");
        }

        private void AddSpaggettiToWater()
        {
            Console.WriteLine("Add spaggetti to water");
            spaggettiCount -= 200;
        }

        private void PutMeatInTigan()
        {
            Console.WriteLine("Put meat in tigan");
            meatCount -= 100;
        }

        private void AddSauceToMeat()
        {
            Console.WriteLine("Add sauce to meat");
        }

        private void PutSpaggetiAndSauceInTheDish()
        {
            Console.WriteLine("Put spaggeti and sauce in the dish");
        }
    }
}
