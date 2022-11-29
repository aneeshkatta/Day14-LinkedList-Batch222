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
            Console.WriteLine("Welcome! Enter a program number\n1.LinkedList-Uc1-createList\n2.LinkedList-Uc2-addfirst\n3.LinkedList-Uc3-add last\n4.LinkedList-Uc4-insert node\n5.LinkedList-Uc5-delete node");
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
            }
        }
    }
}
