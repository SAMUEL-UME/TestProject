
using System;

namespace TimeInCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the timezone ID of the country (e.g., 'Eastern Standard Time', 'Central European Standard Time'):");
            string timeZoneId = Console.ReadLine();

            try 
            {
                // Get the specified timezone
                TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);

                // Get the current time in that timezone
                DateTime currentTime = TimeZoneInfo.ConvertTime(DateTime.Now, timeZone);

                Console.WriteLine($"The current time in {timeZoneId} is: {currentTime}");
            }
            catch (TimeZoneNotFoundException)
            {
                Console.WriteLine("The specified timezone ID was not found.");
            }
            catch (InvalidTimeZoneException)
            {
                Console.WriteLine("The specified timezone ID is invalid.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
