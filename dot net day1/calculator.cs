using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigmments
{
    class assign3
    {
        static void Main(string[] args)
        {
          bool  cond = true;
            while (cond)
            {
                {
                    Console.WriteLine("Calculator");
                    Console.WriteLine("Enter the value1");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the value 2");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the operator to perform");
                    switch (Console.ReadLine())
                    {
                        case "+":
                            Console.WriteLine("The sum of two numbers are " + (a + b));
                            break;
                        case "-":
                            Console.WriteLine("The sub of two numbers is " + (a - b));
                            break;
                        case "*":
                            Console.WriteLine("the multiply of two numbers is " + (a * b));
                            break;

                        case "/":
                            Console.WriteLine("the division of two numbers is " + (a / b));
                            break;
                        default:
                            Console.WriteLine("enter the valid symbol");
                            break;
                    }
                    Console.WriteLine("*********************************");
                    Console.WriteLine("enter 0 to abort calculation");
                    Console.WriteLine("type any number to continue");
                    int opt = Convert.ToInt32(Console.ReadLine());
                    if (opt == 0)
                        cond = false;
                }
                Console.WriteLine("*********************************");
                Console.WriteLine("calculation ended");

            }
               
            }
        }
    }

