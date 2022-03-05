using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        

        static void Main()
        {
            Queue<int> queue = new CircularQueue<int>(10);
            //queue.EnQueue(4);
            //queue.EnQueue(4);
            //Console.WriteLine(queue.Count);
            //Console.WriteLine(queue.DeQueue());

            //return;

            for (int i = 0; i < 10; i++)
            {
                queue.EnQueue(i);
            }

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(queue.DeQueue());
            }

            Console.WriteLine(queue.Count);
        }
        
    }
}