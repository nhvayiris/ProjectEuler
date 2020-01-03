//https://projecteuler.net/

using System;
using System.Linq;

namespace ProjectEuler
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Problem1();
            Problem2();
            Problem3();
            Problem4();
            Problem5();
            Console.ReadKey();

        }
        static void Problem1()
        {
            int sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Project Euler Q1; Multiples of 3 and 5 = " + sum);
        }

        static void Problem2()
        {
            int f = 0, p = 0 ,sum = 0;

            while (f <= 4000000)
            {
                if (f % 2 == 0)
                {
                    sum += f;
                }

                int tF = f;

                if (f <= 1)
                {
                    f++;
                }
                else
                {
                    f += p;
                }

                p = tF;
            }
            Console.WriteLine("Project Euler Q2; Even Fibbonaci Numbers = " + sum);
        }

        static void Problem3()
        {
            long n = 600851475143L;

            for (long i = 2; i < n; ++i)
            {
                while (n % i == 0)
                {
                    n /= i;
                }
            }
            Console.WriteLine("Project Euler Q3; Largest Prime Factor = " + n);

        }

        static void Problem4()
        {
            int palindrome(int firstHalf)
            {
                char[] reversed = firstHalf.ToString().Reverse().ToArray();
                return Convert.ToInt32(firstHalf + new string(reversed));
            }

            bool found = false;
            int firstHalf = 998, p = 0;
            int[] factors = new int[2];

            while (!found)
            {
                firstHalf--;
                p = palindrome(firstHalf);
                for (int i = 999; i > 99; i--)
                {
                    if ((p / i) > 999 || i * i < p)
                    {
                        break;
                    }

                    if ((p % i == 0))
                    {
                        found = true;
                        factors[0] = p / i;
                        factors[1] = i;
                        break;
                    }
                }
            }
            Console.WriteLine("Project Euler Q3; Largest Palindrome Product = {0}, which is made from {1}*{2}", p, factors[0], factors[1]);
        }

        static void Problem5()
        {
            int i = 20;

            while (i % 2 != 0 || i % 3 != 0 || i % 4 != 0 || i % 5 != 0 ||
                     i % 6 != 0 || i % 7 != 0 || i % 8 != 0 || i % 9 != 0 ||
                     i % 10 != 0 || i % 11 != 0 || i % 12 != 0 || i % 13 != 0 ||
                     i % 14 != 0 || i % 15 != 0 || i % 16 != 0 || i % 17 != 0 ||
                     i % 18 != 0 || i % 19 != 0 || i % 20 != 0)
            {
                i += 20;
            }

            Console.WriteLine("Project Euler Q5; Smallest Multiple = " + i);
        }



    }
}

