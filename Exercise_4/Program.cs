using System;

namespace Exercise_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = ReadInput();
            CheckInput(input);
        }

        public static void CheckInput(string input)
        {

            if (input == "Empty")
            {
                Console.WriteLine("Goodbye");
            }
            else
            {
                if (Int32.TryParse(input, out int year))
                {
                    if (year < 1582)
                    {
                        Console.WriteLine("Smallest allowed value is 1582. Try again, or press Space to quit");
                        CheckInput(ReadInput());
                    }
                    else
                    {
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
                }
                else
                {
                    Console.WriteLine("Please enter an integer value or press Space to quit");
                    CheckInput(ReadInput());
                }
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

        private static string ReadInput()
        {
            string input = "Empty";
            string lineRead = Console.ReadLine();
            if (!String.IsNullOrEmpty(lineRead))
            {
                input = lineRead;
            }
            else
            {
                return input;
            }
            return input;
        }

    }
}
