using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Convert a string to an integer using TryParse
            string intString = "123";
            int parsedInt;

            if (int.TryParse(intString, out parsedInt))
            {
                int result = parsedInt * 5;
                Console.WriteLine($"Converted and multiplied by 5: {result}");
            }
            else
            {
                Console.WriteLine($"Error: Failed to parse '{intString}' to integer");
            }

            // Example 2: Convert a string to a DateTime using Convert
            string dateString = "2023-11-08";
            try
            {
                DateTime convertedDate = Convert.ToDateTime(dateString);
                DateTime newDate = convertedDate.AddMonths(-1);
                Console.WriteLine($"Converted to DateTime: {convertedDate}");
                Console.WriteLine($"Subtracting 1 month: {newDate}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Error: '{dateString}' is not a valid DateTime");
            }

            // Example 3: Convert a string to a TimeSpan using Parse
            string timeSpanString = "02:30:00";
            try
            {
                TimeSpan parsedTimeSpan = TimeSpan.Parse(timeSpanString);
                TimeSpan newTimeSpan = parsedTimeSpan.Add(new TimeSpan(2, 0, 0));
                Console.WriteLine($"Parsed TimeSpan: {parsedTimeSpan}");
                Console.WriteLine($"Adding 2 hours: {newTimeSpan}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Error: '{timeSpanString}' is not a valid TimeSpan");
            }
            Console.ReadKey();
        }
    }
}
