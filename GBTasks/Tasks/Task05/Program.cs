using static System.Console;

Clear();

//принимает 3х значное число и возвращает последнюю цифру

WriteLine("Введите трехзначное число: ");
int a =Convert.ToInt32(ReadLine());

if(99<a&&a<1000)
{
    Write($"Последней цифрой числа {a} является {a%10}.");
}
else
{
    Write($"Число {a} не трехзначное!");
}