// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(int a1, int a2, int b1, int b2, int c1, int c2)
{
    double dist = Math.Sqrt((a2 - a1) * (a2 - a1) + (b2 - b1) * (b2 - b1)+(c2 - c1) * (c2 - c1));
    return dist;
}

Console.WriteLine("Введите координаты точки A:");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int c1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int c2 = Convert.ToInt32(Console.ReadLine());



double distance = Distance(x1, x2, y1, y2, c1, c2);
Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));
