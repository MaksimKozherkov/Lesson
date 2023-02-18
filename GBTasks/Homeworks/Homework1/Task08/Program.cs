using static System.Console;

Clear();

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

WriteLine("Введите число N: ");
int n = Convert.ToInt32(ReadLine()!);

int count = 1;
WriteLine($"Четные числа от 1 до {n}: ");
while (count <= n)
{
    if (count % 2 == 0)
    {
        Write($"{count} ");
    }
    count++;
}