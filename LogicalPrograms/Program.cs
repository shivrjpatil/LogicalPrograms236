﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("welcome to Logical Programs");
                Console.WriteLine("Choose the program below");
                Console.WriteLine("1.Fibonacci Series \n2.Perfect Number\n3.Prime Number\n4.Reverse Number\n5.Coupan Number\n6.Stop Watch");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries series = new FibonacciSeries();
                        series.Fibonacci();
                        break;
                    case 2:
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.Perfect();
                        break;
                    case 3:
                        PrimeNumber primeNumber=new PrimeNumber();
                        primeNumber.Prime();
                        break;
                    case 4:
                        ReverseNumber reverse=new ReverseNumber();  
                        reverse.Reverse();
                        break;
                    case 5:
                        CouponNumber.GenerateCoupons(5);
                        break;
                    case 6:
                        StopWatcher stop=new StopWatcher();
                        stop.satrtstop();
                        break;
                        Console.ReadLine();
                }
            }
        }
    }
}
