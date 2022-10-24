using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgoritma
{
    class Program
    {
        int[] arr = new int[20];
        int n;
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("enter the number of elements in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 20 elements.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------");
            Console.WriteLine("Enter Array Element");
        }
    }
}

