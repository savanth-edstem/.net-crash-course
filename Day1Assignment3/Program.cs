int anyNumber = 0;
Random rnd= new Random();
int secretNumber=rnd.Next(0,100);
Console.WriteLine(secretNumber);

Console.WriteLine("***** WELCOME TO FOTUNE GAME *****");

for (int chance=5;chance>0; chance--)
{
    Console.Write("Enter a number(0-100): ");
    anyNumber=Convert.ToInt32(Console.ReadLine());
    if (secretNumber < anyNumber)
    {
        Console.WriteLine("guessed number is grater than secret number");
    }
    else if(secretNumber > anyNumber)
    {
        Console.WriteLine("guessed number is less than secret number");
    }
    else if (secretNumber == anyNumber)
    {
        Console.WriteLine("***** YOU WIN *****");
        break;
    }
    else
    {
        Console.WriteLine("invalid input");
    }
    Console.WriteLine($"You have {chance - 1} chance left");
}
if (secretNumber != anyNumber)
{
    Console.WriteLine("***** better luck next time! *****");
}

Console.WriteLine($"The secret number was :{secretNumber}");