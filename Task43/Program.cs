// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Для того, чтобы найти точку пересечения двух прямых, заданных уравнениям, вам необходимо ввести следующие значения параметров:");
Console.Write("k1 = ");
double k1=Convert.ToInt32(Console.ReadLine());
Console.Write("b1 = ");
double b1=Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
double k2=Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
double b2=Convert.ToInt32(Console.ReadLine());

double SearchX(double a1,double c1,double a2,double c2)
{
    double resultX=(c2-c1)/(a1-a2);
    return resultX;
}

double SearchY(double a1, double c1, double x)
{
    double resultY=a1*x+c1;
    return resultY;
}

double x= Math.Round(SearchX(k1,b1,k2,b2), 2);
double y=Math.Round(SearchY(k1,b1,x), 2);

if (k1 == k2) Console.WriteLine("Прямые параллельныe");
else Console.WriteLine($"Координаты точки пересечения двух прямых равны ({x}; {y})");