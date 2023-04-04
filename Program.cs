// See https://aka.ms/new-console-template for more information

//Header
Console.WriteLine("Welcome!");
Console.WriteLine();

//Array Declaration
String[] favoriteDishes =
{
    "Pizza",
    "Poké",
    "Biscuits",
    "Fruit Tart",
    "Spicy chicken wings",
    "Chocolate",
    "Ice Cream",
    "Pancakes",
    "Rice & chicken",
    "Nachos & Guacamole"
};

//Main
Console.WriteLine($"These are my {favoriteDishes.Length} favorite dishes:");
for (int i = 0; i < favoriteDishes.Length; i++)
{

    //Ranking assignment
    Console.Write($" {i + 1}° ");

    //Key role assignment
    string role = "NONE";
    if (i == 0)
        role = "TOP";
    else if (i == favoriteDishes.Length - 1)
        role = "BOTTOM";
    else if (
        favoriteDishes.Length % 2 == 0 /* oddity check*/
        && i + 1 == favoriteDishes.Length / 2 /* even */
        || i == favoriteDishes.Length / 2) /* odd and even */
        role = "MID";

    //Bullet print
    switch (role)
    {
        case "TOP":
            Console.Write("▲");
            break;
        case "BOTTOM":
            Console.Write("▼");
            break;
        case "MID":
            Console.Write("-");
            break;
        default:
            Console.Write("|");
            break;
    }

    //Food print
    Console.Write($" {favoriteDishes[i]}");

    //Added TOP & BOTTOM highlight
    if(role == "TOP")
    {
        Console.Write(" (THE FAVORITE!)");
    } else if(role == "BOTTOM"){
        Console.Write(" (THE LEAST FAVORITE)");
    }

    Console.WriteLine();
}
Console.WriteLine();

//Footer
Console.WriteLine("Thank you!");