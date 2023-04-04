// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome!");
Console.WriteLine();

String[] favoriteDishes =
{
    "Pizza",
    "Poké",
    "Biscuits",
    "Fruit Tart",
    "Spicy chicken wings",
    "Chocolate",
    "Ice Cream",
};

Console.WriteLine($"These are my {favoriteDishes.Length} favorite dishes:");
for (int i = 0; i < favoriteDishes.Length; i++)
{
    Console.Write($" {i + 1}° - {favoriteDishes[i]}");

    if (i == 0)
        Console.Write(" (MY FAVORITE!)");
    else if (i == favoriteDishes.Length - 1)
        Console.Write(" (THE'LESS FAVORITE')");
    else if (false)
    {

    }


    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Thank you!");