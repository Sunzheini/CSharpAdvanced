using System.Reflection;


namespace _13.Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read info about our program in runtime
            Type[] types = 
                Assembly.GetExecutingAssembly().GetTypes();
            foreach (Type type in types)
            {
                Console.WriteLine(type.Name);
            }
        }
    }
}
