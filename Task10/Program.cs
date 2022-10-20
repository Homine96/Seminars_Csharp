/* Задача 10. Напишите программу , которая на вход принимает трехзначное число и 
на выходе показывает вторую цифру этого числа*/

int Number2(int num)
{
    return num / 10 % 10;
}

Console.Write("Введите трехзначное число:   ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 999)  Console.WriteLine("Введено неправильное число");
else Console.WriteLine($"Вторая цифра {Number2(number)}");

