/*
Задача 13.Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
 645 -> 5
 78 -> третьей цифры нет
 32679 -> 6
*/

// int Numb3(int a, int b)
// {
//     int result=0; 
//     if (b < 3) Console.Write("Третьей цифры нет");
//     else
//     {

//         int c = 1;
//         while (b > 3)
//         {
//             c = c * 10;
//             b--;
//         }
//          result = (a / c) % 10;
//         Console.WriteLine($"Третья цифра : {result}");
//     }
//     return result;
// }

// Console.WriteLine("Введите число:    ");
// int num = Convert.ToInt32(Console.ReadLine());
// int integer = num.ToString().Length;
// int final = Numb3(num, integer);

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberstr = Convert.ToString(number);
int dlinanumber = number.ToString().Length;
if (dlinanumber > 2) Console.WriteLine($"Третья цифра введённого числа: { numberstr [2]}");
else Console.WriteLine("третьей цифры нет");