using static System.Console;

Clear();

// напишите программу которая выводить случаайное 3х значное число и удаляет 2 цифру этого числа

int n=new Random().Next(99,1000);
WriteLine(n);
Write(n/100);
Write(n%10);