﻿// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите начальное число M ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конечное число N ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintSum(m, n));

int PrintSum(int m, int n)
{
    int start = m;
    int end = n;
    if (m > n)
    {
        start = n;
        end = m;
    }
    return (end + start) * (end - start + 1) / 2;
}
