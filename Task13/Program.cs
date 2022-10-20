/*
Задача 13.Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
 645 -> 5
 78 -> третьей цифры нет
 32679 -> 6
*/

void NumberDigit(int num)
{
    string numstr=Convert.ToString(num);
    int numlength=num.ToString().Length;
    if (numlength > 2) Console.WriteLine($"Третья цифра введённого числа: { numstr [2]}");
    else Console.WriteLine("третьей цифры нет");
}

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

NumberDigit(number);