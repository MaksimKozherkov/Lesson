using static System.Console;

Clear();

WriteLine("Введите число: ");

// int a=int.TryParse(ReadLine()!, out a);
int a = Convert.ToInt32(ReadLine());
WriteLine($"Квадрат числа {a} равен {a*a}");