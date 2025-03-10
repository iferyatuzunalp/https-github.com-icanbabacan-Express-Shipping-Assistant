using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Show welcome message to user
                Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
                
                // Get weight and validate
                Console.WriteLine("Please enter the package weight:");
                float weight;
                if (!float.TryParse(Console.ReadLine(), out weight))
                {
                    throw new FormatException("Invalid input for weight. Please enter a numeric value.");
                }
                
                // Check weight restriction
                if (weight > 50)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                    return;
                }
                
                // Get dimensions with validation
                Console.WriteLine("Please enter the package width:");
                float width;
                if (!float.TryParse(Console.ReadLine(), out width))
                {
                    throw new FormatException("Invalid input for width. Please enter a numeric value.");
                }
                
                Console.WriteLine("Please enter the package height:");
                float height;
                if (!float.TryParse(Console.ReadLine(), out height))
                {
                    throw new FormatException("Invalid input for height. Please enter a numeric value.");
                }
                
                Console.WriteLine("Please enter the package length:");
                float length;
                if (!float.TryParse(Console.ReadLine(), out length))
                {
                    throw new FormatException("Invalid input for length. Please enter a numeric value.");
                }
                
                // Validate total dimensions
                if (width + height + length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    return;
                }
                
                // Calculate shipping cost
                float quote = (width * height * length * weight) / 100;
                
                // Display formatted quote
                Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
                Console.WriteLine("Thank you!");
            }
            catch (FormatException ex)
            {
                // Handle input format errors
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle any other unexpected errors
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                // Keep console window open
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
            }
        }
    }
}