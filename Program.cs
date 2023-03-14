// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

using System;
using static System.Console;

Clear();
WriteLine("Введите значение M: ");
int numM = int.Parse(ReadLine());

WriteLine("Введите значение N: ");
int numN = int.Parse(ReadLine());

void GapNumSum (int numM, int numN, int sum)
{
    if (numM > numN)
    {
        WriteLine($"-> {sum}");
        return;
    }
    sum = sum + (numM++);
    GapNumSum (numM, numN, sum);
}
GapNumSum(numM, numN, 0);




