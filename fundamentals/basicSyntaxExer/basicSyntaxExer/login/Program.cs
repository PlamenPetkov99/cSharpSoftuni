using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            int attempts = 0;
            bool isBlocked = false;

            for (int i = username.Length-1; i >= 0; i--)
            {
                password = password + username[i];
            }

            string guess = Console.ReadLine();

            while(guess != password)
            {
                attempts = attempts + 1;
                if (attempts == 4)
                {
                    isBlocked = true;
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                guess = Console.ReadLine();
            }
            if (isBlocked)
            {
                Console.WriteLine($"User {username} blocked!");
            }
            else
            {

                Console.WriteLine($"User {username} logged in.");
            }
            

        }
    }
}
