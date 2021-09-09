using System;
using System.IO;
using Xunit;

namespace Exercise_4.Tests
{
    public class LeapYearTest
    {
        [Fact]
        public void IsLeapYear_returns_true_for_input_divisible_by_four()
        {
            bool returned = Program.IsLeapYear(8);

            Assert.True(returned);
        }

        [Fact]
        public void IsLeapYear_returns_false_for_input_not_divisible_by_four()
        {
            bool returned = Program.IsLeapYear(7);

            Assert.False(returned);
        }

        [Fact]
        public void IsLeapYear_returns_false_for_input_divisible_by_100()
        {
            bool returned = Program.IsLeapYear(100);

            Assert.False(returned);
        }

        [Fact]
        public void IsLeapYear_returns_true_for_input_divisible_by_4_not_100()
        {
            bool returned = Program.IsLeapYear(104);

            Assert.True(returned);
        }

        [Fact]
        public void IsLeapYear_returns_true_for_input_divisible_by_400()
        {
            bool returned = Program.IsLeapYear(400);

            Assert.True(returned);
        }

        [Fact]
        public void Main_prints_yay_if_input_is_leap_year()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            var userInput = new StringReader("2000");
            Console.SetIn(userInput);

            Program.Main(new string[0]);

            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("yay", output);
        }

        [Fact]
        public void Main_prints_nay_if_input_is_not_leap_year()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            var userInput = new StringReader("1997");
            Console.SetIn(userInput);

            Program.Main(new string[0]);

            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("nay", output);
        }
    }
}
