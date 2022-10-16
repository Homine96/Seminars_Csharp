/* Напишите программу , которая на вход подает два числа и выдает ,
каео число минимальное , а какое максимальное. */

Console.WriteLine("Введите число №1:     ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число №2:     ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) Console.Write($"Максимальное число: {a}  Минимальное число: {b}");
if (b > a)  Console.Write($"Максимальное число: {b}  Минимальное число: {a}");
if (a == b) Console.Write("Числа равны");
