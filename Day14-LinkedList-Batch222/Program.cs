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
            Console.WriteLine("Welcome! Enter a program number\n1.LinkedList-Uc1\n2.LinkedList-Uc2\n3.LinkedList-Uc3\n4.LinkedList-Uc4");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    LinkedListUc LL = new LinkedListUc();
                    LL.Addlast(56);
                    LL.Addlast(30);
                    LL.Addlast(70);
                    LL.Display(); 
                    break;
                case 2:
                    LinkedListUc customLL = new LinkedListUc();
                    customLL.AddAtfirst(70);
                    customLL.AddAtfirst(30);
                    customLL.AddAtfirst(56);
                    customLL.Display();
                    break;
                case 3:
                    LinkedListUc customLL1 = new LinkedListUc();
                    customLL1.AddAtfirst(56);
                    customLL1.Addlast(30);
                    customLL1.Addlast(70);
                    customLL1.Display();
                    break;
                case 4:
                    LinkedListUc customLL2 = new LinkedListUc();
                    customLL2.Addlast(70);
                    customLL2.AddAtfirst(56);
                    customLL2.Display();
                    customLL2.InsertAfterPrevious(56, 30, 70);
                    customLL2.Display();
                    break;
            }
        }
    }
}
