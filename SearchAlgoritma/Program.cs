﻿using System;
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
            Console.WriteLine("-----------------");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        public void BinarySearch()
        {
            char ch;
            do
            {
                Console.Write("\nEnter element want you to search :");
                int item = Convert.ToInt32(Console.ReadLine());

                int lowerbound = 0;
                int upperbound = n - 1;

                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                while ((item != arr[mid]) && (lowerbound <= upperbound))
                {
                    if (item > arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;

                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item == arr[mid])
                    Console.WriteLine("\n" + item.ToString() + "found at potition" + (mid + 1).ToString());
                else
                    Console.WriteLine('\n' + item.ToString() + "not found in the array\n");
                Console.WriteLine("\nNumber of comparasion :" + ctr);

                Console.Write("\nContinue search (y/n):");
                ch = char.Parse(Console.ReadLine());
            } while ((ch == 'y') || (ch == 'Y'));
        }
        public void LinierSearch()
        {
            char ch;
            int ctr;
            do
            {
                Console.WriteLine("\nEnter the element you want to search:");
                int item = Convert.ToInt32(Console.ReadLine());

                ctr = 0;
                for (i = 0; i < n; i++)
                {
                    ctr++;
                    if (arr[i] == item)
                    {
                        Console.WriteLine("\n" + item.ToString() + "found st position" + (i + 1).ToString());
                        break;
                    }
                }
                if (i == n)
                    Console.WriteLine("\n" + item + ToString() + "not found in the array");
                Console.WriteLine("\nNumber of comparision:" + ctr);
                Console.Write("\nContinue search (y/n):");
                ch = char.Parse(Console.ReadLine());
            } while ((ch == 'y') || (ch == 'Y'));
        }
        static void Main(string[] args)
        {
            Program myList = new Program();
            int pilianmenu;
            do
            {
                Console.WriteLine("Menu Option");
                Console.WriteLine("========================");
                Console.WriteLine("1.Linier Search");
                Console.WriteLine("2.Binary Search");
                Console.WriteLine("3.Exit");
                Console.Write("Enter your choice (1,2,3) :");
                pilianmenu = Convert.ToInt32(Console.ReadLine());

                switch (pilianmenu)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("linier Search");
                        Console.WriteLine("-------------------------");
                        myList.input();
                        myList.LinierSearch();
                        break;

                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("Binary Search");
                        Console.WriteLine("-------------------------");
                        myList.input();
                        myList.BinarySearch();
                        break;

                    case 3:
                        Console.WriteLine("exit.");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                Console.WriteLine("\n\nPress Return to Exit.");
                Console.ReadLine();
            } while (pilianmenu != 3);
                   
        }
    }
}

