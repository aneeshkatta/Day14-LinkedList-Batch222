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
            Console.WriteLine("Welcome! Enter a program number\n1.LinkedListUc1\n2.LinkedListUc2");
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
            }
        }
    }
}
