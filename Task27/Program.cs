// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10

Console.Write("Введите число: ");
int num=Math.Abs(Convert.ToInt32(Console.ReadLine()));

int SumDigit(int num)
{
    int sum=0;
   
    while(num>=10)
    {
        sum=sum+num%10;
        num=num/10;
       
    }
    sum=sum+num;
    return sum;
}

int result=SumDigit(num);
Console.WriteLine($"Сумма цифр числа {num} = {result}");