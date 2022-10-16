// Программа, которая на вход принимает число N,а на выходе показывает все четные числа от 1 до N

Console.Write("Введите число :  ");
int N = Convert.ToInt32(Console.ReadLine());

int a = 1;
while (a <= N)
{
    if (a % 2 ==0 )
    Console.Write($"{a} ");
    a ++ ;
}
if (N <= 1) Console.Write("Нет чётных чисел");
