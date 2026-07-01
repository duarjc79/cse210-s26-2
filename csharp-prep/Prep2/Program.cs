using System;

Console.WriteLine("--- Basic Adder ---");
Console.WriteLine("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int sum = num1 + num2;
Console.WriteLine($"The result of {num1} + {num2} is: {sum}");