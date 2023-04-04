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
    Console.WriteLine($" {i+1}° - {favoriteDishes[i]}");
}
Console.WriteLine();

Console.WriteLine("Thank you!");