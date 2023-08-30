using System;
using System.Collections.Generic;
using System.Threading.Channels;

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

            // Console.WriteLine(stack.Contains(2)); // true

            var arrayA = stack.ToArray();
            var lisA = stack.ToList();

            // Console.WriteLine(String.Join(", ", arrayA));
            // Console.WriteLine(String.Join(", ", lisA));
            stack.Clear();

            List<int> list = new List<int> { 1, 2 };
            list.Add(3);
            list.Add(4);
            list.RemoveAt(list.Count - 1);  // remove last element

            int topListElement = list[list.Count - 1];
            // Console.WriteLine($"Top List Element: {topListElement}");

            // Task1();
            // Task2();

            // ---------------------------------------------------

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            // Console.WriteLine(queue.Count);
            // Console.WriteLine(queue.Peek());
            // Console.WriteLine(queue.Dequeue());

            // Task3();
            Task4();
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

        static void Task2()
        {
            int sum = 0;

            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var stack = new Stack<int>(input);

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] tokens = command.Split();
                string action = tokens[0];

                if (action == "add")
                {
                    int first = int.Parse(tokens[1]);
                    int second = int.Parse(tokens[2]);
                    stack.Push(first);
                    stack.Push(second);
                }
                if (action == "remove")
                {
                    int howManyToRemove = int.Parse(tokens[1]);

                    if (howManyToRemove <= stack.Count)
                    {
                        for (int i = 0; i < howManyToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }

            foreach (int item in stack)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }

        static void Task3()
        {
            List<int> evenNumbers = new List<int>();
            Queue<int> queue = new Queue<int>();

            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            foreach (var item in input)
            {
                if (item % 2 == 0)
                {
                    queue.Enqueue(item);
                }
            }

            Console.WriteLine(String.Join(", ", queue));
        }

        static void Task4()
        {
            List<string> children = Console.ReadLine()
                .Split()
                .ToList();

            int rounds = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(children);

            while (queue.Count > 1)
            {
                for (int i = 1; i < rounds; i++)
                {
                    string currentChild = queue.Dequeue();
                    queue.Enqueue(currentChild);
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
