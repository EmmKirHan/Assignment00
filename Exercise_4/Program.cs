using System;

namespace Exercise_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int year = Int32.Parse(input);
            bool isLeapYear = IsLeapYear(year);
            if (isLeapYear)
            {
                Console.Write("yay");
            }
            else
            {
                Console.Write("nay");
            }
        }

        public static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 != 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            else
            {
                return false;
            }
        }

    }
}
