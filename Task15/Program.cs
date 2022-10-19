/*Напишите программу, которая на вход цифру,обозначающую день недели
и проверяет является ли этот день выходным*/
Console.Write("Введите число:  ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 0 && a < 6) Console.Write("Будний день");
else if (a > 5 && a < 8) Console.Write("Выходной день");
else Console.Write("Такого дня недели не существует");