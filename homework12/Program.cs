// See https://aka.ms/new-console-template for more information
using homework12.Models;

Console.WriteLine("Hello, World!");
Calculation calculation = new Calculation();
Console.WriteLine(calculation.Addition(5, 6));
Console.WriteLine(calculation.Division(5, 0));
Console.WriteLine(calculation.Multiple(4,6));
Console.WriteLine(calculation.Substraction(7,3));

