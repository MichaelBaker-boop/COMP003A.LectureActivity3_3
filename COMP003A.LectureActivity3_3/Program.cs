//Author: Michael Baker
//Course: COMP-003A
//Faculty: Jonathan Cruz
//Purpose: Demonstrate advanced control statements in C#
namespace COMP003A.LectureActivity3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Advanced Control Statements Demo!\n");

            int range; //The range of numbers to iterate through
            //Get the range of numbers to iterate through
            while (true)
            {
                //try-catch block to handle invalid input
                try
                {
                    //Prompt user to enter a positive integer
                    Console.Write("Enter a positive integer to iterate through");
                    //Parse the input to an integer
                    range = int.Parse(Console.ReadLine());
                    // Check if the number is positive
                    if (range <= 0) throw new Exception("Number must be positive.");
                    //Exit the loop if the input is valid
                    break;
                }
                catch (Exception ex)
                {
                    // Display an error message and prompt the user to try again
                    Console.WriteLine($"Invalid input: (ex.Message\nPlease try again.\n");
                }
            }
        }   
    }
}
