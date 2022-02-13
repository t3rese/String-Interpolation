using System;

namespace String_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            var pi = Math.PI;

            //1.January 22, 2019 (right aligned in a 40 character field)
            var dt1 = ($"{today:M}, {today:yyyy}");
            Console.WriteLine($"1.{dt1,40}");

            //2.2019.01.22
            Console.WriteLine($"2.{today:yyyy}.{today:MM}.{today:dd}"); 

            //3.Day 22 of January, 2019
            var dt3 = ($"Day {today:dd} of {today:MMMM},{today:yyyy}");
            Console.WriteLine($"3.{dt3}");

            //4.Year: 2019, Month: 01, Day: 22
            Console.WriteLine($"4.Year:{today:yyyy},Month:{today:MM},Day:{today:dd}");

            //5.            Tuesday (10 spaces total, right aligned)
            Console.WriteLine($"5.{today,10:dddd}");

            //6.     11:01 PM             Tuesday (10 spaces total for each including the day-of-week, both right-aligned)
            var dt6Time = ($"{today:hh:mm} PM" );
            var dt6Day = ($"{today:dddd}");
            Console.WriteLine("6.{0,10}{1,10}",dt6Time,dt6Day );

            //7.h:11, m:01, s:27
            Console.WriteLine($"7.h:{today:hh}, m:{today:mm}, s:{today:ss}");

            //8.2019.01.22.11.01.27
            Console.WriteLine($"8.{today:yyyy}.{today:MM}.{today:dd}.{today:hh}.{today:mm}.{today:ss}");
            
            //9. Output PI as currency
            Console.WriteLine($"9.{pi:C}");

            //Output as right-aligned (10 spaces), number with 3 decimal places
            Console.WriteLine($"10.{pi,10:n3}");
        }
    }
}