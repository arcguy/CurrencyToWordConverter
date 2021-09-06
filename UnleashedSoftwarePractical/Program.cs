using System;

namespace UnleashedSoftwarePractical
{
    public class Program
    {
        /*
         *  Write a piece of code in C# to convert to convert any amount to its English
            currency representation in words.

            Example:
            Input Output
            1.15 “One dollar and fifteen cents”

            Include all your code (with unit tests) and any supporting references, including
            any limitations or references that are needed to compile and run the solution.
            Also include instructions for how to run/use your application, including any
            limitations or instructions.
            You may wrap the code in a web app or command line tool, whichever you
            prefer.
         */
        static void Main(string[] args)
        {
            CurrencyConverter c = new CurrencyConverter();
            while (true)
            {
                try
                {
                
                    Console.WriteLine("Enter an amount of money to convert to words. Please do not input any commas or currency symbols. To exit, type exit and press Enter");
                    string line = Console.ReadLine().ToLower();
                    if (line == "exit")
                        break;
                    else
                    {
                        decimal money = decimal.Parse(line);
                        if (money > -1)
                            Console.WriteLine(c.CurrencyToWords(Math.Round(money, 2)));
                        else
                            Console.WriteLine("Please enter an amount greater than 0");  
                        Console.WriteLine();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter only numeric values and ensure there are no commas or currency values");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Please enter a value no larger than " +Int32.MaxValue);
                }
            }
            
        }
    }
}
