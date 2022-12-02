//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Enter the number:");

int Day = Convert.ToInt32(Console.ReadLine());


if (Day == 0 || Day == 6)

{
    Console.WriteLine($"The {Day} is holyday!");
}

else
{
    Console.WriteLine("Working day");
}