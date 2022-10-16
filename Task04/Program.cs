// Программа, которая на входи принимает три числа и выдает максимальное

int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

Console.WriteLine("Введите число №1:     ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число №2:     ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число №1:     ");
int c = Convert.ToInt32(Console.ReadLine());

int max = Max (a, b, c);
Console.WriteLine($"Максимальное число: {max}");
