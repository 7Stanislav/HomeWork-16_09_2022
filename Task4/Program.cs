// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите число N ");
int n = int.Parse(Console.ReadLine());

int x = 2;

while (x < n + 1) // Поскольку это не уточняется в условии - четные числа выводятся по N включительно
{
    Console.Write($"{x} ");
    x = x + 2;
}