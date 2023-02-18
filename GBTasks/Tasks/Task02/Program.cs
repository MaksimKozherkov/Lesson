using static System.Console;

Clear();

// Напишите программу которая принимает на вход 2 числа и проверяет является ли 2 число квадратом первого

WriteLine("Введите число а: ");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите число b:");
int b = Convert.ToInt32(ReadLine());

if(a*a==b)
{
    WriteLine($"Число {b} является квадратом числа {a}.");
}
else
{
    WriteLine($"Число {b} не является квадратом числа {a}.");
}