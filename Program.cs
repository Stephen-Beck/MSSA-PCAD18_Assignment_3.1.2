/*
If year is leap

Given a year as integer, write a method that checks if year is leap.

Expected input and output:
IfYearIsLeap(2016) → true 
IfYearIsLeap(2018) → false
*/

namespace Assignment_3._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                uint year = 0;
                
                Console.Write("Enter a year: ");
                if (uint.TryParse(Console.ReadLine().Trim(), out year))
                    Console.WriteLine($"The year {year} {(IsLeapYear(year) ? "is" : "is not")} a leap year.\n");
                else
                    Console.Write("Invalid entry. ");
            }
            
        }

        static bool IsLeapYear(uint year)
        {
            //if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) // if year is divisible by 4 and not 100, OR if it is divisible by 400, it is a leap year
            //    return true;
            //else 
            //    return false;

            return ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);
        }
    }
}
