using static System.Console;

Clear();


// напишите программу которая принимает на вход число n,и выводит все числа от 1 до n

WriteLine("Введите число n: ");
int n=Convert.ToInt32(ReadLine());
int x=1;
Write($"Числа от 1 до {n}: ");
while(x<=n)
{
    Write($"{x} ");
    x++;
}