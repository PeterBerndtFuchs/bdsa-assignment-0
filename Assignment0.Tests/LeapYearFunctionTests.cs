using System;
using System.IO;
using Xunit;

namespace Assignment0.Tests
{
    public class LeapYearFunctionTests
    {
        [Theory]
        [InlineData(1904)]
        [InlineData(2000)]
        [InlineData(0)]
        [InlineData(8008)]
        [InlineData(5916)]
        [InlineData(2308)]
        public void IsLeapYearReturnsTrueOnLeapYear(int year)
        {
            Assert.True(LeapYearFuction.IsLeapYear(year));
        }
        
        [Theory]
        [InlineData(1900)]
        [InlineData(1901)]
        [InlineData(8003)]
        [InlineData(8007)]
        [InlineData(5909)]
        [InlineData(2300)]
        public void IsLeapYearReturnsFalseOnNonLeapYear(int year)
        {
            Assert.False(LeapYearFuction.IsLeapYear(year));
        }
    }
}