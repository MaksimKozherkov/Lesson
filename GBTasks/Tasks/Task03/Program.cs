using static System.Console;

Clear();

// будет выдавать название дня недели по номеру

WriteLine("Введите номер дня недели: ");
int a = Convert.ToInt32(ReadLine());

if (a < 1 || a > 7)
{
    WriteLine("В неделе 7 дней!");
}

if (a == 1)
{
    WriteLine("Понедельник.");
}

if (a == 2)
{
    WriteLine("Вторник");
}

if (a == 3)
{
    WriteLine("Среда.");
}

if (a == 4)
{
    WriteLine("Четверг.");
}

if (a == 5)
{
    WriteLine("Пятница.");
}

if (a == 6)
{
    WriteLine("Суббота.");
}

if (a == 7)
{
    WriteLine("Воскресенье.");
}