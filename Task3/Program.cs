﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.Write($"Число {number} является четным");
}
else
{
    Console.Write($"Число {number} является нечетным");
} 