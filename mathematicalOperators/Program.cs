﻿int num1 = 11;
int num2 = 12;

Console.WriteLine($"Addition: {num1+num2}");
Console.WriteLine($"Subtraction: {num1 - num2}");
Console.WriteLine($"Division: {num1 / num2}");
Console.WriteLine($"Multiplication: {num1 * num2}");
Console.WriteLine($"Modulus: {num1 % num2}");
Console.WriteLine();

num1 = num1 + 4;
Console.WriteLine($"New value for num1: {num1}");
Console.WriteLine($"Addition: {num1 + num2}");
Console.WriteLine($"Subtraction: {num1 - num2}");
Console.WriteLine($"Division: {num1 / num2}");
Console.WriteLine($"Multiplication: {num1 * num2}");
Console.WriteLine($"Modulus: {num1 % num2}");

num1+= 4;
Console.WriteLine($"New value for num1 after += {num1}");
num1 -= 4; 
Console.WriteLine($"New value for num1 after -= {num1}");
num1 *= 4; 
Console.WriteLine($"New value for num1 after *= {num1}");
num1 /= 4; 
Console.WriteLine($"New value for num1 after /= {num1}");
num1 %= 4; 
Console.WriteLine($"New value for num1 after %= {num1}");
