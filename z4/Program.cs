﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите положительное число: ");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

for (int i = 1; i <= number; i++)
{
    if (i % 2 == 0)
{
    Console.Write($"{i}, ");
}}

if (number < 1)
{
    Console.WriteLine("Вы ввели неверное число");
}