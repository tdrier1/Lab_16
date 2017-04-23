using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_16
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            //main loop used to run console app
            do
            {
                //intro statements
                Console.WriteLine("Lets locate some primes!");
                Console.WriteLine("\nThis application will find you any prime, in order, from first prime number on.");
                //gathering input from user
                Console.Write("\n\nWhich prime number are you looking for?");
                int input = GetInt();
                //method call to run the prime number check
                PrimeLoop(input);
                //prompt asking user to continue
                run = Cont();

                Console.Clear();

            } while (run == true);

            Console.Write("Thank you!\n\n");
        }
        public static int GetInt()
        {
            //ensure the user enters a valid integer input
            int value;

            while (!Int32.TryParse(Console.ReadLine(), out value))
            {
                {
                    Console.WriteLine("\n");
                    Console.Write("Try again! Please enter an integer: ");
                }

            }
            return value;
        }
        public static void PrimeLoop(int input)
        {
            //method that runs the check on every number going up until the user input is met
            int p = 0;
            bool prime;

            for (int i = 2; i <= int.MaxValue; i++)
            {
                prime = PrimeTest(i);
                if (prime == true)
                {
                    p++;
                }
                if (p == input)
                {
                    //returns value back to user
                    Console.WriteLine("\n\nThe number " + input + " prime is " + i);
                    break;
                }
            }
        }
        public static bool PrimeTest(int num1)
        {
            //actual math being done to check if the number is prime
            if (num1 == 0) return false;
            if (num1 == 1) return false;

            for (int i = 2; i < num1; i++)
                if (num1 % i == 0)
                {
                    return false;
                }
            return true;
        }
        public static bool Cont()
        {
            //details of the continue loop in console
            string conf;
            bool check = true;
            bool run = true;

            Console.WriteLine("\n=============================");
            Console.WriteLine("\nWould you like to play again?");
            Console.Write("\nPlease Enter (y/n): ");

            do
            {
                conf = Console.ReadLine();
                var t = conf.ToLower();

                if (t != "y" || t != "n")
                {
                    Console.Write("\nPlease Enter (y/n): ");
                }
                if (t == "y")
                {
                    Console.Clear();
                    check = false;
                }

                if (t == "n")
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for playing!");

                    run = false;
                    check = false;
                }
            } while (check == true);
            return run;
        }
    }
}
