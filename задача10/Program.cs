//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Enter the number from 100 to 999: ");

int number = Convert.ToInt32(Console.ReadLine());

number = number/10;
int SecondNumber = number % 10;

Console.Write("The second number is " + SecondNumber);
Console.WriteLine();

