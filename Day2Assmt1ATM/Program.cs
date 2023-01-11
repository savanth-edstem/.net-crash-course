int balance = 5000;
string run = string.Empty;

bool Verification()
{
    int cardNnumber = 56789;
    int pinNumber = 1234;
    Console.Write("Enter the card number: ");
    int newCardNumber = Convert.ToInt32(Console.ReadLine());
    if (newCardNumber == cardNnumber)
    {
        Console.Write("Enter the pin number: ");
        int newPinNumber = Convert.ToInt32(Console.ReadLine());
        if (newPinNumber == pinNumber)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    {
        return false;
    }
}


void MenuScreen()
{
    Console.WriteLine();
    MenuOptions('b', "Balance");
    MenuOptions('d', "Deposit");
    MenuOptions('w', "Withdraw");
    MenuOptions('q', "Quit");
    char menuOption = Convert.ToChar(Console.ReadLine());
    switch (menuOption)
    {
        case 'b':
            Balance();
            break;
        case 'd':
            Deposit();
            break;
        case 'w':
            Withdraw();
            break;
        case 'q':
            run = "e";
            break;
        default:
            UnknownMenu();
            break;

    }
}


void MenuOptions(char character, string option)
{
    Console.WriteLine($"Press {character} to {option}");
}


void Balance()
{
    Console.WriteLine($"Your balance is {balance}");
}


void UnknownMenu()
{
    Console.WriteLine("Incorrect entry or no option selected");
    Console.WriteLine("Try again");
}

void Deposit()
{
    Console.Write("Enter the amount to deposit: ");
    int amount = Convert.ToInt32(Console.ReadLine());
    balance += amount;
    Console.WriteLine("Successful");
    Console.WriteLine($"Your new balance: {balance}");
}

void Withdraw()
{
    Console.Write("Enter the amount to withdraw: ");
    int amount = Convert.ToInt32(Console.ReadLine());
    balance -= amount;
    Console.WriteLine("Successful");
    Console.WriteLine($"Your new balance: {balance}");
}

try
{

    if (Verification() == true)
    {
        do
        {
            MenuScreen();
        }
        while (!run.Equals("e"));
    }
    else
    {
        Console.WriteLine("Unable to verify credentials!");
    }


}
catch (FormatException)
{
    Console.WriteLine("invalid entry!!!");
}
catch (Exception)
{

    throw;
}
finally
{
    Console.WriteLine("Thank You");
}