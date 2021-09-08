using System;
using Xunit;

namespace Exercise_4.Tests
{
    public class LeapYearTest
    {
        [Fact]
        public void IsLeapYear_returns_true_for_input_divisible_by_four()
        {
            Program program = new Program();

            bool returned = program.IsLeapYear(8);

            Assert.True(returned);
        }

        [Fact]
        public void IsLeapYear_returns_false_for_input_not_divisible_by_four()
        {
            Program program = new Program();

            bool returned = program.IsLeapYear(7);

            Assert.False(returned);
        }

        [Fact]
        public void IsLeapYear_returns_false_for_input_divisible_by_100()
        {
            Program program = new Program();

            bool returned = program.IsLeapYear(100);

            Assert.False(returned);
        }

        [Fact]
        public void IsLeapYear_returns_true_for_input_divisible_by_4_not_100()
        {
            Program program = new Program();

            bool returned = program.IsLeapYear(104);
            Assert.True(returned);
        }

        [Fact]
        public void IsLeapYear_returns_true_for_input_divisible_by_400()
        {
            Program program = new Program();

            bool returned = program.IsLeapYear(400);

            Assert.True(returned);
        }
    }
}
