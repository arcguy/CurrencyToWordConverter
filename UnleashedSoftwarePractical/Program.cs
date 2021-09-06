using System;

namespace UnleashedSoftwarePractical
{
    public class Program
    {
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
                        double money = double.Parse(line);
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
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
        }
    }
}
