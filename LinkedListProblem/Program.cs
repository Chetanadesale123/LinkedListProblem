using System;
using LinkedListProblem;
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("WELCOME IN THE LINKEDLIST");
        LinkedList list = new LinkedList();
        bool check = true;
        Console.WriteLine(" 1 add \n 2.Add Reverse \n 3. Append \n  4. Display \n 5.end");
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
                    list.Append(56);
                    list.Append(30);
                    list.Append(70);
                    break ;
                case 4:
                    list.Display();
                    break;
                case 5:
                    check = false;
                    break;
            }
        }

    }
}
