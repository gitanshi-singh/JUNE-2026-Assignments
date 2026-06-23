using System;
using System.Collections.Generic;
using System.Text;
// WAP to check whether you have applied/submitted your exam form before deadline or not.
//Custom defined exceptions
namespace JUNE_040626
{
    class DeadlineException : Exception
    {
        public DeadlineException(string message) : base(message)
        {
        }
    }
    internal class Q1_examFormException
    {
        public static void Run()
        {
            DateTime deadline = new DateTime(2026, 7, 15);

            Console.Write("Enter submission date (yyyy-mm-dd): ");
            DateTime submissionDate = Convert.ToDateTime(Console.ReadLine());

            try
            {
                if (submissionDate > deadline)
                {
                    throw new DeadlineException("Exam form submitted after the deadline.");
                }
                Console.WriteLine("Exam form submitted successfully");
            }
            catch (DeadlineException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
