using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        

        static void Main()
        {
            List<int> list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            /*
            DynamicList<int> list = new DynamicList<int>();
            for (int i = 0; i < 3454544; i++)
            {
                list.Append(i);
            }
            
            Console.WriteLine(list[1]);
            Console.WriteLine(list[666]);
            Console.WriteLine(list[9999]);
            Console.WriteLine("adfsafdssadfafds");
            list.Clear();
            list.Append(324324);
            list.Append(99999999);
            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            */

            /*
            LinkedList<int> list = new LinkedList<int>();
            list.Append(465);
            list.Append(69);
            list.Append(61);

            Console.WriteLine("Count: " + list.Count);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            */
        }
        
    }
}