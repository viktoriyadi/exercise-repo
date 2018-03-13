﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int middleDashes = 0;

            if (n==1)
            {
                Console.WriteLine("*");
                return;
            }
            
            if (n%2!=0)
            {
                middleDashes++;
                Console.WriteLine(new string('-', n / 2) + "*" + new string('-', n / 2));
            }

            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string('-', n / 2 - 1 - i) + "*");
                Console.Write(new string('-',middleDashes+ 2 * i) + "*");
                Console.WriteLine(new string('-', n / 2 - 1-i));
            }
            for (int i = n/2-2; i >=0; i--)
            {
                Console.Write(new string('-', n / 2 - 1 - i) + "*");
                Console.Write(new string('-', middleDashes+2 * i) + "*");
                Console.WriteLine(new string('-', n / 2 - 1 - i));
            }
            if (n % 2 != 0)
            {
                Console.WriteLine(new string('-', n / 2) + "*" + new string('-', n / 2));
            }
        }
    }
}
