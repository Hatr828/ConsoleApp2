﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool counter = true;
            while (counter == true)
            {
                int Input;
                Console.WriteLine("ведите чесло если хотите выйти нажмите 1");
                Input = Convert.ToInt32(Console.ReadLine());
                if (Input == 1) { break; }
                Console.WriteLine(HW(Input));
            }
        }

        static int HW(int num)
        {
            if(num % 5 != 0) { return -1; }

            int temp = 0;

            for (; num != 0; num /= 10)
            {
                temp = temp * 10 + (num % 10);
            }
            for (; temp != 0; temp /= 10)
            {
                num = num * 10 + (temp % 10);
            }
            num /= 10;

            num = num * num * 100 + 25;

            return num;
        }
    }
}
