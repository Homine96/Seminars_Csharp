/* Задача 10. Напишите программу , которая на вход принимает трехзначное число и 
на выходе показывает вторую цифру этого числа*/

Console.Write("Введите трехзначное число:   ");
int num =Convert.ToInt32(Console.ReadLine());

int Number2(int num)
{
    int a = num / 10;
    int b = a %10;
    return b;
}

int number2=Number2(num);
Console.WriteLine($"Вторая цифра {number2}");
