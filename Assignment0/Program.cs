using System;

namespace Assignment0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            ValidateLeapYear(Console.ReadLine());
        }

        public static void ValidateLeapYear(string input)
        {
            try
            {
                int year = Convert.ToInt32(input);            
                Console.WriteLine(LeapYearFuction.IsLeapYear(year) ? "yay" : "nay");
            }
            catch (Exception e)
            {
                Console.WriteLine("please enter a valid year after 1582");
            }
        }
    }
}
