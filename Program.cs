// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

using System;
using static System.Console;

Clear();
int m = InputNum("Введите m: ");
int n = InputNum("Введите n: ");
int A = Ack(m, n);

Write($"Функция Аккермана = {A} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNum(string input) 
{
  Write(input);
  int output = Convert.ToInt32(ReadLine());
  return output;
}