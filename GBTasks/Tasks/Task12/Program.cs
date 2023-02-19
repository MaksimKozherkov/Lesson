using static System.Console;

Clear();

WriteLine("Введите сколько банок сбил 1 стрелок: ");
int a=Convert.ToInt32(ReadLine()!);
WriteLine("Введите сколько банок сбыл 2 стрелок: ");
int b=Convert.ToInt32(ReadLine()!);

WriteLine($"Всего было {a+b-1} банок");