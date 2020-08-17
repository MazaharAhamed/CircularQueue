using System;
using System.Collections.Generic;
using System.Text;

namespace CircularQueue
{
    class Demo
    {
        static void Main(String[] args)
        {
            int choice, x;

            CircularQ cqA = new CircularQ();

            while(true)
            {
                Console.WriteLine("1.Insert Element in Queue");
                Console.WriteLine("2.Delete Element from Queue");
                Console.WriteLine("3.Front Element in Queue");
                Console.WriteLine("4.Display all elements from Queue");
                Console.WriteLine("5.Queue Size");
                Console.WriteLine("6.Quit");
                Console.WriteLine("Enter Your Choice:");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6)
                    break;

                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Enter the element to insert:");
                        x = Convert.ToInt32(Console.ReadLine());
                        cqA.Insert(x);
                        break;
                    case 2:
                        Console.WriteLine("Deleted Element is: " + cqA.Delete());
                        break;
                    case 3:
                        Console.WriteLine("Front Element in Queue is: " + cqA.Peek());
                        break;
                    case 4:
                        cqA.Display();
                        break;
                    case 5:
                        Console.WriteLine("Queue Size is: " + cqA.Size());
                        break;
                    default:
                        Console.WriteLine("Wrong Choice:");
                        break;
                }
                Console.WriteLine("");
            }
        }
    }
}
