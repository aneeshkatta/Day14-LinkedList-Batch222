using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_LinkedList_Batch222
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome! Enter a program number\n1.LinkedList-Uc1-createList\n2.LinkedList-Uc2-addfirst\n3.LinkedList-Uc3-add last\n4.LinkedList-Uc4-insert node\n5.LinkedList-Uc5-delete first node\n6.LinkedList-Uc6-delete last node\n7.LinkedList-Uc7-Search node\n8.LinkedList-Uc8-Search and Add node\n9.LinkedList-Uc9-Search and delete search node");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    LinkedList LL = new LinkedList();
                    LL.AddLast(56);
                    LL.AddLast(30);
                    LL.AddLast(70);
                    LL.Display(); 
                    break;
                case 2:
                    LinkedList CustomLL = new LinkedList();
                    CustomLL.AddAtFirst(70);
                    CustomLL.AddAtFirst(30);
                    CustomLL.AddAtFirst(56);
                    CustomLL.Display();
                    break;
                case 3:
                    LinkedList CustomLL1 = new LinkedList();
                    CustomLL1.AddAtFirst(56);
                    CustomLL1.AddLast(30);
                    CustomLL1.AddLast(70);
                    CustomLL1.Display();
                    break;
                case 4:
                    LinkedList CustomLL2 = new LinkedList();
                    CustomLL2.AddLast(70);
                    CustomLL2.AddAtFirst(56);
                    CustomLL2.Display();
                    CustomLL2.InsertBetween(56, 30, 70);
                    CustomLL2.Display();
                    break;
                case 5:
                    LinkedList CustomLL3= new LinkedList();
                    CustomLL3.AddLast(56);
                    CustomLL3.AddLast(30);
                    CustomLL3.AddLast(70);
                    CustomLL3.Display();
                    CustomLL3.DeleteFirstNode(56);
                    CustomLL3.Display();
                    break;
                case 6:
                    LinkedList CustomLL4 = new LinkedList();
                    CustomLL4.AddLast(56);
                    CustomLL4.AddLast(30);
                    CustomLL4.AddLast(70);
                    CustomLL4.Display();
                    CustomLL4.DeleteLastNode(70);
                    CustomLL4.Display();
                    break;
                case 7:
                    LinkedList CustomLL5 = new LinkedList();
                    CustomLL5.AddLast(56);
                    CustomLL5.AddLast(30);
                    CustomLL5.AddLast(70);
                    Console.WriteLine("Searching node with data {0} in Linked list",30);
                    CustomLL5.Search(30);
                    break;
                case 8:
                    LinkedList CustomLL6 = new LinkedList();
                    CustomLL6.AddLast(56);
                    CustomLL6.AddLast(30);
                    CustomLL6.AddLast(70);
                    CustomLL6.SearchNodeAddNode(30,40);//insert 40 to 30;
                    CustomLL6.Display();
                    break;
                case 9:
                    LinkedList CustomLL7 = new LinkedList();
                    CustomLL7.AddLast(56);
                    CustomLL7.AddLast(30);
                    CustomLL7.AddLast(40);
                    CustomLL7.AddLast(70);
                    Console.WriteLine("Before deletion:");
                    CustomLL7.Display();
                    Console.WriteLine("After deletion:");
                    CustomLL7.SearchNodeDeleteNode(40);//search and delete 40 ;
                    CustomLL7.Display();
                    break;
            }
        }
    }
}
