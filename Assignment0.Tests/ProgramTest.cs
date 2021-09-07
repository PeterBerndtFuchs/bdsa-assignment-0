using System;
using Xunit;
using System.IO;

namespace Assignment0.Tests
{
    public class ProgramTest
    {
        /*[Fact]
        public void Main_prints_hello_world()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new String[0]);
            
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Hello World!",output);
        }*/
        
        [Theory]
        [InlineData("1904")]
        [InlineData("2000")]
        [InlineData("0")]
        [InlineData("8008")]
        [InlineData("5916")]
        [InlineData("2308")]
        public void ValidateLeapYear_Prints_Yay(string year)
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.ValidateLeapYear(year);
            
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("yay",output);
        }
        
        [Theory]
        [InlineData("1905")]
        [InlineData("2001")]
        [InlineData("1")]
        [InlineData("8009")]
        [InlineData("5917")]
        [InlineData("2309")]
        public void ValidateLeapYear_Prints_Nay(string year)
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.ValidateLeapYear(year);
            
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("nay",output);
        }
        
        [Theory]
        [InlineData("2012a")]
        [InlineData("The year one")]
        [InlineData("nineteeneightyfour")]
        [InlineData("one hundred")]
        [InlineData("Seven")]
        [InlineData("It's over 9000")]
        public void ValidateLeapYear_Prints_enter_valid_year(string year)
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.ValidateLeapYear(year);
            
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("please enter a valid year after 1582",output);
        }
    }
}