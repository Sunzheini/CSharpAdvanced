namespace AllLessons
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            TestMe testMe = new TestMe();
            testMe.Test();
        }
    }

    public class TestMe
    {
        public void Test()
        {
            Console.WriteLine("Test123, do you hear me?");
        }
    }
}