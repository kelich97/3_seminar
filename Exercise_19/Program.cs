﻿/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
void Nemo(int arg )
{
    int a = (number / 10000);
    int b = (number / 1000 % 10);
    int c = (number % 100 / 10);
    int d = (number % 10);
    if((a == d) && (b == c))
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
Nemo(number);

