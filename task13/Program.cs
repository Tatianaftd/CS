﻿// Задача 13. Напишите программу, которая
// 1. выводит третью цифру заданного числа
// 2. или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99)   // проверяем, что разрядов более, чем 2
{
    while (num > 999) 
    num /= 10;
    num %= 10;

    Console.WriteLine($"Третья цифра числа равна {num} ");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

// int GetThirdDigit(int param)
// {
//     while (param > 999) param /= 10;    // уменьшаем до 3-х разрядов
//     param %= 10;                        // получаем младший разряд
//     return param;
// }

// Console.Write("Введите любое число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num > 99)   // проверяем, что разрядов более, чем 2
// {
//     int thirdDig = GetThirdDigit(num);
//     Console.WriteLine($"Третья цифра числа {num} равна {thirdDig}");
// }
// else
// {
//     Console.WriteLine("Число имеет менее 3-х знаков!");
// }