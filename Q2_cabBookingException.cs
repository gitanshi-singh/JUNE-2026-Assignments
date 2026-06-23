using System;
using System.Collections.Generic;
using System.Text;
//Create an application for cab booking. But the gps service fails or invalid location entered
//Exception handling
namespace JUNE_040626
{
    class GPSException : Exception
    {
        public GPSException(string message) : base(message) { }
    }

    class InvalidLocationException : Exception
    {
        public InvalidLocationException(string message) : base(message) { }
    }
    internal class Q2_cabBookingException
    {
        public static void Run()
        {
            try
            {
                Console.Write("Enter pickup location: ");
                string location = Console.ReadLine();

                if (string.IsNullOrEmpty(location))
                {
                    throw new InvalidLocationException("Invalid location entered.");
                }
                Console.Write("Is GPS available? (yes/no): ");
                string gps = Console.ReadLine();

                if (gps.ToLower() == "no")
                {
                    throw new GPSException("GPS service failed.");
                }

                Console.WriteLine("Cab booked successfully.");
            }
            catch(InvalidLocationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(GPSException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
