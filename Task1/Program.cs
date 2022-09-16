// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int number2 = int.Parse(Console.ReadLine());

if (number > number2)
{
    Console.Write($"Первое число {number} больше второго числа {number2}");
}
else
{
    Console.Write($"Второе число {number2} больше первого числа {number}");
} 