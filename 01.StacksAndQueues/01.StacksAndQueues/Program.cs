using System;
using System.Collections.Generic;

namespace _01.StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Peek();
            // Console.WriteLine($"Elements inside: {stack.Count}");
            
            int topStackElement = stack.Pop();
            // Console.WriteLine($"Top Stack Element: {topStackElement}");

            List<int> list = new List<int> { 1, 2 };
            list.Add(3);

            int topListElement = list[list.Count - 1];
            // Console.WriteLine($"Top List Element: {topListElement}");

            Task1();
        }

        static void Task1()
        {
            Console.WriteLine("Enter a string:");
            var inputString = Console.ReadLine();
            var reversedStack = new Stack<char>();
             
            foreach (var x in inputString)
            {
                reversedStack.Push(x);
            }

            while (reversedStack.Count > 0)
            {
                Console.Write(reversedStack.Pop());
            }
        }
    }
}