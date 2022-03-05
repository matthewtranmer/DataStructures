using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main()
        {
            Stack<int> stack = new DynamicStack<int>();
            for (int i = 0; i < 1000000000; i++)
            {
                stack.Push(i);
            }

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}