//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

//AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2 - формула расчёта расстояния между точками в трёхмерном пространстве

int[] pointA = new int[3];
Console.WriteLine("Введите координаты точки A: ");
Console.Write("x = ");
pointA[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
pointA[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("z = ");
pointA[2] = Convert.ToInt32(Console.ReadLine());

int[] pointB = new int[3];
Console.WriteLine("Введите координаты точки B: ");
Console.Write("x = ");
pointB[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
pointB[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("z = ");
pointB[2] = Convert.ToInt32(Console.ReadLine());

// Немного замороченный ввод, зато можно будет принимать массивы откуда-то ещё, чтом=б работать с ними. :)

double ABDistance(int[] a, int[] b)
{
    double distance = Math.Sqrt(Math.Pow(b[0] - a[0], 2) + Math.Pow(b[1] - a[1], 2) + Math.Pow(b[2] - a[2], 2));
    return distance;
}
Console.Write("Расстояние между точками: ");
Console.WriteLine(ABDistance(pointA, pointB));

