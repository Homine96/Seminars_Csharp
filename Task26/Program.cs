// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b=Convert.ToInt32(Console.ReadLine());

int Stepen(int num1, int num2)
{
    int num3=1;
    if (num2<0) return -1;
    else if (num2==0) return 1;
    else
     for (int i=1; i<=num2;i++)
     {
       num3=num3*num1;
     }
     return num3;
}

int result=Stepen(a,b);
Console.Write(result<0?"Некорректное значение степени": $"Число {a} в степени {b} = {result}");
// if (result<0) Console.WriteLine("Введено неккоректное значние степени");
// else Console.Write($"Число {a} в степени {b} = {result}");