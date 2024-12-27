using System;

class Program
{
    static void Main()
    {
        // Display title
        Console.WriteLine("Console Calculator App");
        Console.WriteLine("-----------------------");

        // Main loop
        while (true)
        {
            try
            {
                // Display available operations
                Console.WriteLine("\nChoose an operation:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                // Read user choice
                string choice = Console.ReadLine();

                // Exit the program if the user selects "5"
                if (choice == "5")
                {
                    Console.WriteLine("Exiting the calculator...");
                    break;
                }

                // Ask for input numbers
                Console.Write("Enter the first number: ");
                double num1 = GetNumberFromUser();

                Console.Write("Enter the second number: ");
                double num2 = GetNumberFromUser();

                // Perform the operation based on user choice
                double result = 0;
                bool validOperation = true;

                switch (choice)
                {
                    case "1":
                        result = num1 + num2;
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;
                    case "2":
                        result = num1 - num2;
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;
                    case "3":
                        result = num1 * num2;
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;
                    case "4":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;
                    default:
                        validOperation = false;
                        Console.WriteLine("Invalid operation. Please choose a valid option.");
                        break;
                }

                // Ask if the user wants to continue
                if (validOperation)
                {
                    Console.Write("\nDo you want to perform another calculation? (y/n): ");
                    string continueChoice = Console.ReadLine();
                    if (continueChoice.ToLower() != "y")
                    {
                        Console.WriteLine("Exiting the calculator...");
                        break;
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid input format. Please enter valid numbers.");
                Console.WriteLine($"Details: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                // Optionally clean up or log errors, if needed
            }
        }
    }

    // Helper function to get a valid number from user input
    static double GetNumberFromUser()
    {
        while (true)
        {
            try
            {
                string input = Console.ReadLine();
                double number = Convert.ToDouble(input);
                return number;
            }
            catch (FormatException)
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }
        }
    }
}
