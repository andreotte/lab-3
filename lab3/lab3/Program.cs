using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int number;
            
            Console.WriteLine("Hello!" + "\n" + "Please enter your name: ");
            name = Console.ReadLine();

            while (true)
            {
                Console.WriteLine($"{name}, please enter a number: ");

                try
                {
                    number = Convert.ToInt32(Console.ReadLine());

                    if (number > 100 || number < 0)
                    {
                        Console.WriteLine("please enter a number between 1 - 100");
                        continue;
                    }

                    if (number > 60)
                    {
                        if (number % 2 == 0)
                        {
                            Console.WriteLine($"{number} and Even");
                        }
                        else
                        {
                            Console.WriteLine($"{number} and Odd");
                        }
                    }
                    else if (number % 2 == 0 && number >= 26)
                    {
                        Console.WriteLine("Even");
                    }
                    else if (number % 2 == 0 && number <= 25)
                    {
                        Console.WriteLine($"Even and less than 25");
                    }
                    else
                    {
                        Console.WriteLine($"{number} and Odd");
                    }

                    Console.WriteLine($"{ name}, would you like to continue?");
                    string userContinue = Console.ReadLine().ToLower();

                    if (userContinue == "no" || userContinue == "n")
                    {
                        Console.WriteLine($"OK. goodbye, {name}");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter number in integer format.");
                    continue;
                }               
            }  
        }
    }
}
