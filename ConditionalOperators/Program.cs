Console.Write("Enter the number of apples: ");
int numberOfApples=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of Oranges: ");
int numberOfOranges = Convert.ToInt32(Console.ReadLine());


if (numberOfApples > numberOfOranges)
{
    Console.WriteLine("more apples");
}
else if (numberOfOranges > numberOfApples)
{
    Console.WriteLine("more oranges");
}
else if (numberOfApples == numberOfOranges)
{
    Console.WriteLine("equal number of apples and oranges");
}
else
{
    Console.WriteLine("invalid");
}


Console.Write("enter mark (0-100): ");
int marks=Convert.ToInt32(Console.ReadLine());
switch (marks)
{
    case int n when (n < 50):
        Console.WriteLine("You are failed");
        break;
    case int n when (n >= 50 && n <= 100):
        Console.WriteLine("you are pass");
        break;
    default: 
        Console.WriteLine("invalid");
        break;
}

//ternery operation
var message = numberOfApples > numberOfOranges ? "we have more apples" : "we have less apples";
Console.WriteLine(message);