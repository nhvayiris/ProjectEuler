//https://projecteuler.net/

using System;
using System.Collections.Generic;
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
            Problem6();
            Problem7();
            Problem8();
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

        static void Problem6()
        {
            long sum = 0;
            long squared = 0;
            long result = 0;

            const int N = 100;

            sum = N * (N + 1) / 2;
            squared = (N * (N + 1) * (2 * N + 1)) / 6;

            result = sum * sum - squared;

            Console.WriteLine("Project Euler Q6; Sum Square Difference= " + result);
        }

        static void Problem7()
        {
            bool isPrime(int numm)
            {
                if (numm <= 1)
                {
                    return false;
                }

                if (numm == 2)
                {
                    return true;
                }

                if (numm % 2 == 0)
                {
                    return false;
                }

                int counter = 3;

                while ((counter * counter) <= numm)
                {
                    if (numm % counter == 0)
                    {
                        return false;
                    }
                    else
                    {
                        counter += 2;
                    }
                }

                return true;
            }

            int numPrimes = 1;
            int numm = 1;

            while (numPrimes < 10001)
            {
                numm = numm + 2;
                if (isPrime(numm))
                {
                    numPrimes++;
                }
            }

            Console.WriteLine("Project Euler Q7; 10001st prime = " + numm);
        }

        static void Problem8()
        {

            string s = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";

            int adjacent = 13;

            long max = 0;

            for (int i = 0; i < s.Length - adjacent + 1; i++)
            {
                long thisproduct = 1;
                for (int j = 0; j < adjacent; j++)
                {
                    thisproduct = thisproduct * Convert.ToInt32(((s[i + j])).ToString());
                }
                if (thisproduct > max)
                {
                    max = thisproduct;
                }
            }
            Console.WriteLine("Project Euler Q8; Largest product in a series = " + max);
        }

        }

    }


