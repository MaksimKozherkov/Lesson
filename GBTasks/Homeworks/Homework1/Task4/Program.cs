using static System.Console;

Clear();

//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


WriteLine("Введите число a: ");
int a =Convert.ToInt32(ReadLine()!);
WriteLine("Введите число b: ");
int b=Convert.ToInt32(ReadLine()!);
WriteLine("Введите число c: ");
int c=Convert.ToInt32(ReadLine()!);

int max=0;

if(a>max)
{
    max=a;
}

if(b>max)
{
    max=b;
}
if(c>max)
{
    max=c;
}

WriteLine($"Среди чисел {a} {b} {c} самым большим будет {max}.");
