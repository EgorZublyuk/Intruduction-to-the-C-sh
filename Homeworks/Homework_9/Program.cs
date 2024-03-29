﻿// Итоговое задание по рекурсии!

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void ShowNumbers(int N)
// {
//     if( N >= 1)
//     {
//         Console.Write(N + " ");
//         ShowNumbers(N-1);
        
//     }
// }
// Console.Write ("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// ShowNumbers(num);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

 Console.Write ("Input number N: ");
int N = Convert.ToInt32(Console.ReadLine());
 Console.Write ("Input number M: ");
int M = Convert.ToInt32(Console.ReadLine());

// int FindSum (int n, int m)
// {
//     if( n != m)
//     {
//     if ( n > m)
//     {
//         return FindSum(n - 1, m) + n;
//     }
//     else
//     {
        
//         return FindSum(n + 1, m) + n;
        
//     }
//     }
//     else return n;
// }

// Console.WriteLine(FindSum(N,M));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int FunctionAkkerman (int m, int n)
{
    if (m == 0)
        {
            return n + 1;
        }
        else if((m > 0) && (n == 0))
        {
            return FunctionAkkerman(m - 1, 1);
        }
        else if((m > 0) && (n > 0))
        {
            return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
        }else
        return n + 1;
}

Console.WriteLine(FunctionAkkerman(M,N));
