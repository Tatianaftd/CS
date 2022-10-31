// // Напишите программу, которая будет 
// 1. Выдавать название дня недели по заданному номеру.
// // 3 -> Среда
// // 5 -> Пятница

// Console.WriteLine("Введите целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if (number == 2) // Чтобы программа не проверяла все остальные 
// {
//     Console.WriteLine("Вторник");
// }
// else if (number == 3)
// {
//     Console.WriteLine("Среда");
// }
// else if (number == 4)
// {
//     Console.WriteLine("Четверг");
// }
// else if (number == 5)
// {
//     Console.WriteLine("Пятница");
// }
// else if (number == 6)
// {
//     Console.WriteLine("Суббота");
// }
// else if (number == 7)
// {
//     Console.WriteLine("Воскресенье");
// }
// else
// {
//     Console.WriteLine("В неделе 7 дней");
// }

// Второй вариант решения более верный 
Console.WriteLine("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 0 && day < 8) // Прежде чем проверять нужно задать диапозон
{
    if (day == 1)
    {
        Console.WriteLine("Понедельник");
    }
    else if (day == 2) // Чтобы программа не проверяла все остальные 
    {
        Console.WriteLine("Вторник");
    }
    else if (day == 3)
    {
        Console.WriteLine("Среда");
    }
    else if (day == 4)
    {
        Console.WriteLine("Четверг");
    }
    else if (day == 5)
    {
        Console.WriteLine("Пятница");
    }
    else if (day == 6)
    {
        Console.WriteLine("Суббота");
    }
    else if (day == 7)
    {
        Console.WriteLine("Воскресенье");
    }
}  
    else
    {
        Console.WriteLine("Заданное число не соответсвует дню недели");
    }

