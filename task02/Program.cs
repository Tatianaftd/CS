// Напишите программу, которая на вход 
// 1. Принимает два числа 
// 2. Выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.Write("Введите целое число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1>number2)
{
   Console.WriteLine("Первое число больше второго");
}
else if (number1<number2)
{
   Console.WriteLine("Первое число меньше второго");
}
else
{
   Console.WriteLine("Числа равны"); 
}