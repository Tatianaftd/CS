﻿// Напишите программу, которая 
// 1. принимает на вход три числа 
// 2. выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите целое число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;
if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}
Console.WriteLine($"Максимальное из введенных чисел равно: {max}");
