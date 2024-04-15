using System;

class Program
{
    static void Main(string[] args)
    {
        Recipe recipe = new Recipe();

        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n======== Recipe Manager ========");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Enter Recipe Details");
            Console.WriteLine("2. Display Recipe");
            Console.WriteLine("3. Scale Recipe");
            Console.WriteLine("4. Reset Quantities");
            Console.WriteLine("5. Clear All Data");
            Console.WriteLine("6. Exit");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nEnter your choice: ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nInvalid choice. Please enter a number.");
                Console.ResetColor();
                ContinueMessage();
                continue;
            }

            switch (choice)
            {
                case 1:
                    recipe.EnterRecipeDetails();
                    break;
                case 2:
                    recipe.DisplayRecipe();
                    break;
                case 3:
                    double factor = GetScaleFactor();
                    recipe.ScaleRecipe(factor);
                    recipe.DisplayRecipe();
                    break;
                case 4:
                    recipe.ResetQuantities();
                    break;
                case 5:
                    recipe.ClearRecipe();
                    break;
                case 6:
                    exit = true;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nExiting program. Have a nice day!");
                    Console.ResetColor();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nInvalid choice. Please enter a number between 1 and 6.");
                    Console.ResetColor();
                    ContinueMessage();
                    break;
            }
        }
    }

    static double GetScaleFactor()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n======== Scale Factor ========");
        Console.WriteLine("Select a scale factor:");
        Console.WriteLine("1. Half (0.5)");
        Console.WriteLine("2. Normal (1.0)");
        Console.WriteLine("3. Double (2.0)");
        Console.WriteLine("4. Triple (3.0)");
        Console.ResetColor();

        double factor = 1.0; // Default to normal scale
        bool validChoice = false;

        while (!validChoice)
        {
            Console.Write("\nEnter your choice: ");
            if (double.TryParse(Console.ReadLine(), out double choice))
            {
                switch (choice)
                {
                    case 1:
                        factor = 0.5; // Half
                        validChoice = true;
                        break;
                    case 2:
                        factor = 1.0; // Normal
                        validChoice = true;
                        break;
                    case 3:
                        factor = 2.0; // Double
                        validChoice = true;
                        break;
                    case 4:
                        factor = 3.0; // Triple
                        validChoice = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nInvalid choice. Please enter a number between 1 and 4.");
                        Console.ResetColor();
                        break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nInvalid input. Please enter a valid number.");
                Console.ResetColor();
            }
        }

        return factor;
    }

    static void ContinueMessage()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nPress any key to continue...");
        Console.ResetColor();
        Console.ReadKey();
    }
}
