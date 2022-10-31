// Напишите программу, которая 
// 1. принимает на вход трёхзначное число 
// 2. и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    number /= 10;
    number %= 10;
    
    Console.WriteLine($"Вторая цифра числа равна {number} ");
}
else
{
    Console.WriteLine("Число имеет менее 3-х знаков!");
}


// int GetSecondDigit(int param)
// {
//     param /= 10;    // уменьшаем до 2-х разрядов
//     param %= 10;    // получаем младший разряд
//     return param;
// }

// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num > 99)   // проверяем, что разрядов более, чем 2
// {
//     int secDig = GetSecondDigit(num);
//     Console.WriteLine($"Вторая цифра числа {num} равна {secDig}");
// }
// else
// {
//     Console.WriteLine("Число имеет менее 3-х знаков!");
// }