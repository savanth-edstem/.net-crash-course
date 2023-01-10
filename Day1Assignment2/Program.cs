double numberOne , numberTwo , numberThree = 0.0;

Console.Write("Enter first number: ");
numberOne=Convert.ToDouble(Console.ReadLine());

Console.Write("Enter second number: ");
numberTwo = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter third number: ");
numberThree = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"The result is: {(((numberOne + numberTwo) / numberThree) * numberOne)}");