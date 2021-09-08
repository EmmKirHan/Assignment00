using System;

namespace Exercise_4
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public bool IsLeapYear(int year)
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
