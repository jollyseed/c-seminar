﻿Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b == a * a)
{
    Console.WriteLine("Да");
}
else 
{
Console.WriteLine("Нет");
}