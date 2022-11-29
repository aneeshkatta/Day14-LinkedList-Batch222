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
            Console.WriteLine("Welcome! Enter a program number\n1.LinkedList-Uc1-createList\n2.LinkedList-Uc2-addfirst\n3.LinkedList-Uc3-add last\n4.LinkedList-Uc4-insert node");
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
                    LinkedList customLL1 = new LinkedList();
                    customLL1.AddAtFirst(56);
                    customLL1.AddLast(30);
                    customLL1.AddLast(70);
                    customLL1.Display();
                    break;
                case 4:
                    LinkedList customLL2 = new LinkedList();
                    customLL2.AddLast(70);
                    customLL2.AddAtFirst(56);
                    customLL2.Display();
                    customLL2.InsertBetween(56, 30, 70);
                    customLL2.Display();
                    break;
            }
        }
    }
}
