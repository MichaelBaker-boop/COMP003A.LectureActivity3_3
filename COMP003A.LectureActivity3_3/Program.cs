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
            // Get the user's preferences for skipping and terminating the loop
            Console.Write("Would you like to skip a number? (yes/no)");
            // Convert the response to lowercase to make it case-insensitive
            string skipResponse = Console.ReadLine().ToLower();
            // Initialize the skip number to zero
            int skipNumber = 0;
            // Check if the user wants to skip a number
            if (skipResponse == "yes") 
            {
                // Prompt user to enter the skipped number
                Console.Write("Enter the number to skip:");
                skipNumber = int.Parse(Console.ReadLine());
            }

            // Get the user's preference for terminating the loop
            Console.Write("Would you like to terminate the loop at a specific number? (yes/no): ");
            // Convert to make response case-insensitive
            string terminateResponse = Console.ReadLine().ToLower();
            // Initialize the termination number to zero
            int terminateNumber = 0;
            // Check if user wants to terminate loop
            if (terminateResponse == "yes")
            {
                // Prompt user to enter the termination number
                Console.Write("Enter the termination number: ");
                // Parse the input to an integer
                terminateNumber = int.Parse(Console.ReadLine());
            }

            // Display the output
            Console.WriteLine("\nOutput:");
            // Iterate through the range of numbers
            for (int i = 1; i <= range; i++) 
            {
                // Check if current number is the number to skip
                if (i == skipNumber) 
                {
                    continue; // Skip the specified number
                }
                // Check if current number is the number to terminate
                if (i == terminateNumber)
                {
                    //Display a message and break out of the loop
                    Console.WriteLine($"Loop terminated at number {terminateNumber}");
                    break; // Terminate the loop
                }

                // Display the current number
                Console.WriteLine(i);

            }

            // Prompt the user to restart the program
            Console.Write("Enter 'restart' to try again or any other key to exit: ");
            string restart = Console.ReadLine().ToLower();

            // Check if the user wants to restart the program
            if (restart == "restart") 
            {
                // Restart the program
                goto restart;
            }
        // Label to restart the program
        restart:
            //Display a message and restart the program
            Console.WriteLine("Restarting the program...\n");
            //Restart the program
            Main(args); // Restart the program
                

        }   
    }
}
