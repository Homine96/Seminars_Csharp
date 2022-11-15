// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] CreateArray(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        Console.Write($"Введите число № {i+1} : ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(",");
    }
    Console.WriteLine("");
}

int NumberPlus(int [] arr)
{
    int result=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0) result+=1;
    }
    return result;
}

Console.WriteLine("Введите количество чисел(N): ");
int n= Convert.ToInt32(Console.ReadLine());

int [] array= CreateArray(n);
int plus=NumberPlus(array);
Console.Write($"В ряду чисел: ");
PrintArray(array);
Console.WriteLine($"{plus} числа(чисел) больше 0");
