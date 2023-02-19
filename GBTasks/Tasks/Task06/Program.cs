using static System.Console;

Clear();

// напишите программу которая вводит рандомное число от10 до 99 и показывает наибольшую цифру числа

int number=new Random().Next(10,100);
WriteLine(number);
WriteLine(number%2==0?"Even":"odd");
// int a1=number/10;
// int a2=number%10;
// int max=a1>a2?a1:a2;
// WriteLine(a1>a2?a1:a2);
WriteLine(number/10>number%10?number/10:number%10);

// if(a1>a2)
// {
//     WriteLine(a1);
// }
// else
// {
//     WriteLine(a2);
// }