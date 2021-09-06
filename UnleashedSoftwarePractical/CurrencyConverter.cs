using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace UnleashedSoftwarePractical
{
    public class CurrencyConverter
    {
        private string[] oneto19 = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", 
                                                "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
        private string[] tens = { "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};

        /// <summary>
        /// Usage of truncate to get values before decimal point found here:
        /// https://stackoverflow.com/questions/4604980/how-to-get-value-after-decimal-point-from-a-double-value-in-c/4605098
        /// Use of titlecase to convert first letter of each word to upper case found here:
        /// https://stackoverflow.com/questions/1943273/convert-all-first-letter-to-upper-case-rest-lower-for-each-word
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public string CurrencyToWords(decimal amount)
        {
            string converted;
            decimal dollars = (int)Math.Truncate(amount);
            decimal cents = Math.Round((amount - dollars) * 100, 0);

            Console.WriteLine("Dollars = " + dollars.ToString());
            Console.WriteLine("Cents = " + cents.ToString());

            converted = ConvertAmount(dollars, "d");
            converted += ConvertAmount(cents, "c");

            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(converted.ToLower());
        }

        private string ConvertAmount(decimal amount, string type)
        {
            string converted = "";
            decimal num = amount;
            if (num == 0)
                converted += "Zero";
            //convert billions
            if (num >= 1000000000 && num < 1000000000000)
            { 
                converted += ConvertThousandsPlus(num, 1000000000, "Billion");
                num %= 1000000000;
            }
            //convert millions
            if (num >= 1000000 && num < 1000000000)
            {
                converted += ConvertThousandsPlus(num, 1000000, "Million");
                num %= 1000000;
            }
            //convert thousands
            if (num >= 1000 && num < 1000000)
            {
                converted += ConvertThousandsPlus(num, 1000, "Thousand");
                num %= 1000;
            }            
            //convert hundreds
            if (num >= 100 && num < 1000)
            {
                converted += ConvertHundreds(num);
                num %= 100;
            }
            //convert 20 to 99
            if (num >= 20 && num < 100)
            {
                converted += ConvertTens(num);
                num %= 10;
            }
            //convert 1 to 19
            if (num < 20 && num > 0)
                converted += ConvertLess20(num);
            //add check for 0
            if (type == "d")
            {
                if (amount != 1)
                    converted += " Dollars and ";
                else
                    converted += " Dollar and ";
            }
            else
            {
                if (amount != 1)
                    converted += " Cents";
                else
                    converted += " Cent";
            }

            return converted;
        }

        private string ConvertThousandsPlus(decimal amount, int divider, string denomination)
        {
            string converted = "";
            decimal num = amount / divider;

            if (num > 99)
            {
                converted += ConvertHundreds(num);
                num %= 100;
            }
            if (num > 19)
            {
                converted += ConvertTens(num);
                num %= 10;
            }
            if (num > 0)
                converted += ConvertLess20(num);


            if (amount % divider > 0)
                converted += " " + denomination + " and ";
            else
                converted += " " + denomination;

            return converted;
        }

        private string ConvertHundreds(decimal amount)
        {
            string converted = "";
            converted += ConvertLess20(amount / 100);
            if (amount - 100 > 0)
                converted += " Hundred and ";
            else
                converted += " Hundred";
            return converted;
        }

        private string ConvertTens(decimal amount)
        {
            decimal num = (amount /= 10);

            return tens[(int)num - 1];
        }

        private string ConvertLess20(decimal num)
        {
            return oneto19[(int)num - 1];
        }
    }
}
