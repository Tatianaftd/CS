// Задача 21
// Напишите программу, которая 
// 1. принимает на вход координаты двух точек и 
// 2. находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату точки1: ");
Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки2: ");
Console.Write("X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Range(int x11, int y11, int z11, int x21, int y21, int z21)// Задаем метод и значения этого метода
{
    int rangeX = x11 - x21;// вычисляем первый катет, расстояние между двумя точками X
    int rangeY = y11 - y21;// вычисляем второй катет, расстояние между двумя точками Y
    int rangeZ = z11 - z21;// вычисляем третий катет, расстояние между двумя точками Z
    double range = Math.Sqrt(rangeX * rangeX + rangeY * rangeY + rangeZ * rangeZ); // находим корень суммы квадратов катетов
    return range;
}

double result = Range(x1, y1, z1, x2, y2, z2); // обращаемся к функиции с заданными изначаьлно координатами
Console.Write($"А ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {Math.Round(result, 2, MidpointRounding.ToZero)}");// выводим результат

// Второй вариант
// Метод получает координаты двух точек и возвращает расстояние между ними в 3D пространстве
// double LengthVector(int mx1, int my1, int mz1, int mx2, int my2, int mz2)
// {
//     double xy = Math.Sqrt((mx2 - mx1) * (mx2 - mx1) + (my2 - my1) * (my2 - my1));
//     return Math.Sqrt(xy * xy + (mz2 - mz1) * (mz2 - mz1));
// }

// Console.WriteLine("Введите координаты точки 1:");
// Console.Write("X: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Z: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты точки 2:");
// Console.Write("X: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Z: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double d = LengthVector(x1, y1, z1, x2, y2, z2);
// double res = Math.Round(d, 2, MidpointRounding.ToZero);

// Console.WriteLine($"Расстояние между точками равно {res}");