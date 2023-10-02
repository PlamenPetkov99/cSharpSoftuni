using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string command =Console.ReadLine();
            int sumPrime = 0;
            int sumNon = 0;
            bool isPrime = true;
            while(command != "stop")
            {
                int n = int.Parse(command);
                if(n < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    for (int i = 2; i < n; i++)
                    {
                        if (n % i == 0)
                        {
                            isPrime = false;
                        }
                        else
                        {
                            isPrime = true;
                        }
                    }

                    if (isPrime)
                    {
                        sumPrime = sumPrime + n;
                    }
                    else
                    {
                        sumNon = sumNon + n;
                    }

                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNon}");
            
            
            
            

           
        }
    }
}
