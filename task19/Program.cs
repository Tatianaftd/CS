// Задача 19
// Напишите программу, которая 
// 1. принимает на вход пятизначное число и
// 2. проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да


// Метод void
void ProverkaPalendrom(int param)
{
    int dig5 = param % 10; // получили пятую цифру числа
    int dig4 = param / 10; // уменьшили число до 4 разрядов
    dig4 = dig4 % 10; // получили 4 цифру
    int dig2 = param / 1000; // уменьшили число до 2 разрядов
    dig2 = dig2 % 10; // получили 2 цифру
    int dig1 = param / 10000; // получили 1 число

    if (dig1 == dig5 && dig2 == dig4)
    {
        Console.WriteLine("Число является палиндромом!");
    }
    else
    {
        Console.WriteLine("Число НЕ является палиндромом!");
    }
}

/*
// Метод string
string ProverkaPalendrom(int param)
{
    string result; // мы обьявили строковую переменную для будущего результата
    int dig5 = param % 10; // получили пятую цифру числа
    int dig4 = param / 10; // уменьшили число до 4 разрядов
    dig4 = dig4 % 10; // получили 4 цифру
    int dig2 = param / 1000; // уменьшили число до 2 разрядов
    dig2 = dig2 % 10; // получили 2 цифру
    int dig1 = param / 10000; // получили 1 число

    if (dig1 == dig5 && dig2 == dig4)
    {
        result = "Число является палиндромом!";
    }
    else
    {
        result = "Число НЕ является палиндромом!";
    }
    return result;
}
*/

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999)  // либо >=10000 проверили пятизначное ли это число
{
    if (number <= 99999)
    {  

    // string res = ProverkaPalendrom(number); // первый вариант метода string
    // Console.WriteLine(res);

    // Console.WriteLine(ProverkaPalendrom (number)); // второй вариант для метода string

    ProverkaPalendrom(number); // это для метода void
    }
    else
    {
       Console.WriteLine("Число имеет более 5-ти знаков!"); 
    }

}
else
{
    Console.WriteLine("Число имеет менее 5-ти знаков!");
}

/*
// Вариант первый без метода(функции)
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999) // либо >=10000 проверили пятизначное ли это число
{
    int dig5 = number % 10; // получили пятую цифру числа
    int dig4 = number / 10; // уменьшили число до 4 разрядов
    dig4 = dig4 % 10; // получили 4 цифру
    int dig2 = number / 1000; // уменьшили число до 2 разрядов
    dig2 = dig2 % 10; // получили 2 цифру
    int dig1 = number / 10000; // получили 1 число

    // if (dig1 == dig5) {
    //     if (dig2 == dig4) {
    //       Console.WriteLine("Число является палиндромом!");  
    //     }
    // }
    // Console.WriteLine($"{dig1}, {dig2}, {dig4}, {dig5}");

    if (dig1 == dig5 && dig2 == dig4)
    {
        Console.WriteLine("Число является палиндромом!");
    }
    else
    {
        Console.WriteLine("Число НЕ является палиндромом!");
    }
}
else
{
    Console.WriteLine("Число имеет менее 5-х знаков!");
}
*/


// Второй вариант универсальный
//Метод разворачивает любое натуральное число  

// int TurnOverTheNumber(int param)
// {
//     int newDig = 0; // вводим новое число
//     while (param > 9) 
//     {
//         newDig += param % 10;// newDig = newDig + param % 10
//         newDig *= 10; // 
//         param /= 10;
//     }
//     newDig += param % 10;
//     return newDig;
// }
// Console.Write("Введите натуральное пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num > 0)
// {
//     int numRev = TurnOverTheNumber(num);
//     if (num == numRev)
//         Console.WriteLine($"Число {num} является палиндромом!");
//     else
//         Console.WriteLine($"Число {num} НЕ является палиндромgом!");
// }
// else
//     Console.WriteLine($"Число {num} не является натуральным!");


