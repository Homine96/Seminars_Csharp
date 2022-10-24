//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void Table(int n)
{
    int index = 1;
    while (index <= n)
    {
        Console.WriteLine($"{index,4} {index * index * index ,4}");
        index++;
    }
}

Console.Write("Введите натуральное число:  ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0) Table(n);
else Console.WriteLine("Введено некорректное число");