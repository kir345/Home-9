// Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
//промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;
using static System.Console;

Clear();
Write("Введите число N: ");
int n = int.Parse(ReadLine());

for (int i = n; i > 0; i-- )
{
    Write($"{i} ");
}
WriteLine();
WriteLine(PrintNums(n));

string PrintNums(int n)
{
    if (n == 5)
    {
        WriteLine();
        return "1";
    }
    string s = PrintNums(n + 1) + " " + n.ToString();
    WriteLine(s);
    return s;
}
