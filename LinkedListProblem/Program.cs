using System;
using LinkedListProblem;
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("WELCOME IN THE LINKEDLIST");
        LinkedList list = new LinkedList();
        bool check = true;
        Console.WriteLine(" 1 add \n 2.Add Reverse \n 3.Insert At Particular Position  \n 4.Search Element \n 5.Remove First Node \n 6.Remove Last \n  7. Display \n 8.end");
        while (check)
        {
            Console.WriteLine(" **** ENTER THE ABOVE OPTION TO EXECUTE THE METHODS *****");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("LINKED LIST");
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    break;
                case 2:
                    list.AddInReverseOrder(70);
                    list.AddInReverseOrder(30);
                    list.AddInReverseOrder(56);
                    break;
                case 3:
                    list.Add(56);
                    list.Add(70);
                    int a = list.Search(56);
                    list.InsertAtParticularPosition(a + 1, 30);
                    list.Display();
                    break;
                case 4:
                    Console.WriteLine("SEARCHING ELEMENT ");
                    int node = list.Search(30);
                    Console.WriteLine("element present on the index:-> " + node);
                    list.Display();
                    break;
                case 5:
                    list.RemoveFirstNode();
                    break;
                case 6:
                    list.RemoveLastNode();
                    break;
                case 7:
                    list.Display();
                    break;
                case 8:
                    check = false;
                    break;
            }
        }

    }
}
