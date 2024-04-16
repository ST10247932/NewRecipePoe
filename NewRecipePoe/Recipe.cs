using System;
//Recipe class
class Recipe
{
    private Ingredient[] ingredients;
    private string[] steps;
    // Gets recipe info from the user

    public void EnterRecipeDetails()
    {
        Console.Write("Enter the number of ingredients: ");
        int numIngredients = int.Parse(Console.ReadLine());
        ingredients = new Ingredient[numIngredients];

        for (int i = 0; i < numIngredients; i++)
        {
            Console.WriteLine($"\nEnter details for ingredient #{i + 1}:");
            ingredients[i] = new Ingredient();

            Console.Write("Name: ");
            ingredients[i].Name = Console.ReadLine();

            Console.Write("Quantity: ");
            ingredients[i].Quantity = double.Parse(Console.ReadLine());

            Console.Write("Unit: ");
            ingredients[i].Unit = Console.ReadLine();
        }

        Console.Write("\nEnter the number of steps: ");
        int numSteps = int.Parse(Console.ReadLine());
        steps = new string[numSteps];

        for (int i = 0; i < numSteps; i++)
        {
            Console.Write($"\nEnter step #{i + 1}: ");
            steps[i] = Console.ReadLine();
        }
    }
    // Displays the recipe 
    public void DisplayRecipe()
    {
        Console.WriteLine("\nRecipe Details:");
        Console.WriteLine("Ingredients:");

        foreach (var ingredient in ingredients)
        {
            Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
        }

        Console.WriteLine("\nSteps:");
        for (int i = 0; i < steps.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {steps[i]}");
        }
    }

    public void ScaleRecipe(double factor)
    {
        foreach (var ingredient in ingredients)
        {
            ingredient.Quantity *= factor;
        }
    }

    public void ResetQuantities()
    {
        // Reset quantities to original values
        EnterRecipeDetails();
    }
     // Clear recipe
    public void ClearRecipe()
    {
        ingredients = null;
        steps = null;
    }

}
