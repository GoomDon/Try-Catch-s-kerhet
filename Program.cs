using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_and_catch_safety
{
    class Program
    {
        static int num1;
        static int num2;
        static string input1;
        static string input2;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 integers to add them.\nEnter the first and then click enter to input the other one:");
            input1 = Console.ReadLine();
            input2 = Console.ReadLine();

            Console.WriteLine("Answer without safety:\n");
            wrongSafety(input1, input2);
            Console.WriteLine("\nAnswer with safety:\n");
            rightSafety(input1, input2);
        }
        static void wrongSafety(string input1, string input2)
        {
            try
            {
                int num1 = int.Parse(input1);
                int num2 = int.Parse(input2);
                Console.WriteLine(num1 + num2);
            }
            catch
            {
            }
        }
        static void rightSafety(string input1, string input2)
        {
            try
            {
                num1 = int.Parse(input1);
                num2 = int.Parse(input2);
            }
            catch
            {
                Console.WriteLine("You did not enter 2 integers. Please try again.\n\n");
                Main(null);
            }
            finally
            {
                Console.WriteLine(num1 + num2);
            }
            Console.ReadKey();
        }
    }
}


