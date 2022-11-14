// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

Console.WriteLine("Enter the first number!");
string num1 = Console.ReadLine();
Console.WriteLine("Enter the second number:");
string num2 = Console.ReadLine();
int number1 = Int32.Parse(num1);
int number2 = Int32.Parse(num2);
int addition = number1 + number2;
Console.WriteLine("Addition: " + addition);
int substraction = number1 - number2;
Console.WriteLine("Substraction: " + substraction);
int multiplication = number1 * number2;
Console.WriteLine("Multiplication: " + multiplication);
int division = number1 / number2;
Console.WriteLine("Division: " + division);