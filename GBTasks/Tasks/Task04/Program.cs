using static System.Console;

Clear();


// напишите программу которая принимает на вход число n,и выводит все числа от -n до n

WriteLine("Введите число n: ");
int n=Convert.ToInt32(ReadLine());
int x=-n;
Write($"Числа от {x} до {n}: ");
while(x<=n)
{
    Write($"{x} ");
    x++;
}