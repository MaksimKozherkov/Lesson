using static System.Console;

Clear();

// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

WriteLine("Введидете число a: ");
int a =Convert.ToInt32(ReadLine()!);
WriteLine("Введите число b: ");
int b=Convert.ToInt32(ReadLine()!);

if(a>b)
{
    WriteLine($"Число {a} больше числа {b}.");
}
else
{
    WriteLine($"Число {b} больше числа {a}.");
}