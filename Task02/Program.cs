/* Напишите программу , которая на вход подает два числа и выдает ,
каео число минимальное , а какое максимальное. */

Console.WriteLine("Введите число №1:     ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число №2:     ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = b;

if (a > b) Console.Write($"Максимальное число: {max} , Минимальное число: {min}");
if (b > a)
{
    max = b;
    min = a;
    Console.Write($"Максимальное число: {max} , Минимальное число: {min}");
}
if (a == b) Console.Write("Числа равны");
