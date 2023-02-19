using static System.Console;

Clear();

//принимает на вход 2 числа и проверяет является ли 1 крадратом второго

WriteLine("Введите число a: ");
int a=Convert.ToInt32(ReadLine()!);
WriteLine("Введите число b: ");
int b=Convert.ToInt32(ReadLine()!);

WriteLine(a*a==b?$"Число {b} является квадратом числа {a}.":b*b==a?$"Число {a} является квадратом числа {b}.":$"Числа {a} и {b} не являются квадратами друг друга.");