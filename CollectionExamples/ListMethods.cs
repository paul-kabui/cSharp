using System.Collections.Generic;

namespace ASPSTORE{
    public class ListMethods{
        public static void ListOperation()
        {
            List<int> list = [1,2,3,4];
            Console.WriteLine($"length of list: {list.Capacity}");
            list.Add(6); //add an item
            list.Remove(4); //remove an item
            foreach (var item in list.Slice(1,3)) //interating with slice operations
            {
                Console.WriteLine(item);
            }
        }

        public static void LinkedListOperations()
        {
            LinkedList<int> lst = new();
            lst.AddLast(3);
            lst.AddLast(5);
            lst.AddLast(8);
            lst.AddFirst(9);
            lst.RemoveFirst(); //takes no argument and remove first element
            lst.Remove(5); //removes the specifield element, and takes 1 argument

            foreach (int item in lst)
            {
                Console.WriteLine(item);  
            }
            
        }
    }
}