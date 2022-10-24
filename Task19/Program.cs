//Задача 19.Напишите программу, которая принимает на вход пятизначное число и проверяет
// является ли оно палиндромом, например:
// 14212 - нет
// 12821 - да
// 23432 - да

// void Palindrom(int num)
// {
//     int a = num / 10000;
//     int b = num % 10;
//     int c = num / 1000 % 10;
//     int d = num % 100 /10;
//     if ( a==b && c==d) Console.WriteLine("Число является палиндромом");
//     else Console.WriteLine("Число не является палиндромом");
// }

// Console.Write("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 99999 || number < 10000) Console.WriteLine ("Введено некорректное число")  ;
// else Palindrom(number);




// Решение для ввода любого числа


int Reverse(int num)
{
    int rnum = 0;
    while (num > 0)
    {
        rnum = rnum * 10 + num % 10;
        num = num / 10;
    }
    return rnum;
}


Console.Write("Введите число :   ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int rn = Reverse(n);

 if (n == rn) Console.WriteLine("Введеное число палиндром");
 else Console.WriteLine("Введенное число не палиндром");
