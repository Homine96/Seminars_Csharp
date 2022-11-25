// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void NaturalNumbersMN(int numM, int numN)
{
    if (numM == numN)
    {
        Console.WriteLine($"{numM} ");
        return;
    }
    Console.Write($"{numM} ");
    NaturalNumbersMN(numM > numN ? numM - 1 : numM + 1, numN);
}

void SumNumbersMN(int numM, int numN, int sum)
{
    if (numM == numN )
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum+numM}");
        return;
    }
    sum = sum + numM;
    SumNumbersMN(numM>numN? numM - 1: numM+1, numN, sum);
}

Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
NaturalNumbersMN(m, n);
SumNumbersMN(m, n, 0);
