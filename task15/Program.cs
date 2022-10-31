// Задача 15: Напишите программу, которая
// 1. принимает на вход цифру, обозначающую день недели, 
// 2. и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0 && num < 8) 
{
if (num > 5)
{
    Console.WriteLine($"{num} день выходной!");
}
else
{
Console.WriteLine($"{num} день не выходной!");
}
}
 else
 {
     Console.WriteLine("Число не является днем недели");
 }

// bool isHoliday(int param)
// {
//     if (param > 5)  // выходные только 6 и 7 дни
//         return true;
//     else
//         return false;
// }

// Console.Write("Введите номер дня недели: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num > 0 && num < 8)   // проверяем, что это разумный день недели [1;7]
// {
//     bool restDay = isHoliday(num);
//     if (restDay)
//         Console.WriteLine($"{num} день - это выходной!");
//     else
//         Console.WriteLine($"{num} день - это НЕ выходной!");
// }
// else
// {
//     Console.WriteLine("Число не является днем недели!");
// }