int cardNnumber = 56789;
int pinNumber = 1234;
int balance = 5000;
string run = string.Empty;
try
{
    do
    {
        AtmMachine();
        Console.WriteLine("press any key to continue or \"e\" to exit ");
        run = Console.ReadLine();


        void AtmMachine()
        {
            Console.Write("Enter the card number: ");
            int newCardNumber = Convert.ToInt32(Console.ReadLine());
            if (newCardNumber == cardNnumber)
            {
                Console.Write("Enter the pin number: ");
                int newPinNumber = Convert.ToInt32(Console.ReadLine());
                if (newPinNumber == pinNumber)
                {
                    MenuScreen();
                }
                else
                {
                    Console.WriteLine("Incorrect Entry!");
                }
            }
            else
            {
                Console.WriteLine("Incorrect Entry!");
            }
        }


        void MenuScreen()
        {
            MenuOptions('b', "Balance");
            MenuOptions('d', "Deposit");
            MenuOptions('w', "Withdraw");
            MenuOptions('q', "Quit");
            char menuOption = Convert.ToChar(Console.ReadLine());
            switch (menuOption)
            {
                case 'b':
                    Console.WriteLine($"Your balance is {balance}");
                    break;
                case 'd':
                    Deposit();
                    break;
                case 'w':
                    Withdraw();
                    break;
                case 'q':
                    break;
                default:
                    Console.WriteLine("Incorrect entry or no option selected");
                    Console.WriteLine("Try again");
                    break;

            }
        }


        void MenuOptions(char character, string option)
        {
            Console.WriteLine($"Press {character} to {option}");
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
    }
    while (!run.Equals("e"));
}
catch (FormatException)
{
    Console.WriteLine($"invalid entry");
}
catch (Exception)
{

    throw;
}
finally
{
    Console.WriteLine("Thank You");
}