using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordValidator
{
    class Program
    {

        private static bool Firstrule(string word)
        {
            if(6 <= word.Length && word.Length <= 10)
            {
                return true;
            }
            else
            {
                
                return false;
            }
        }
        private static bool Secondrule(string word)
        {
            word = word.ToLower();
            foreach (char item in word)
            {
                if((97<=(int)item && (int)item <= 122) || (48 <= (int)item && (int)item <= 57))
                {
                    continue;
                }
                else
                {
                    
                    return false;
                }
                
            }

            return true;
        }
        private static bool Thirdrule(string word)
        {
            int countDigits = 0;
            foreach (var item in word)
            {
                switch (item)
                {
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case '0':
                        countDigits = countDigits + 1;
                        break;
                }
            }

            if(countDigits >= 2)
            {
                return true;
            }
            else
            {
                
                return false;
            }

        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool Isvalid = true;


            Isvalid = Firstrule(input); //Console.WriteLine("Password must consist only of letters and digits");
            Isvalid = Secondrule(input); //Console.WriteLine("Password must consist only of letters and digits");
            Isvalid = Thirdrule(input); //Console.WriteLine("Password must have at least 2 digits");

            if(Firstrule(input) == false)
            {
                Isvalid = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (Secondrule(input) == false)
            {
                Isvalid = false;
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (Thirdrule(input) == false)
            {
                Isvalid = false;
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (Isvalid)
            {
                Console.WriteLine("Password is valid");
            }

        }
    }
}
