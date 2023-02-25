// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Input number a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if ( a > b )
// {
//     Console.WriteLine($"Number: {a} - max, number: {b} - min");
// }
// else
// {
//     Console.WriteLine($"NUmber: {b} - max, number: {a} - min");
// }


// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Input number a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number c: ");
// int c = Convert.ToInt32(Console.ReadLine());
// if ( a > b && a > c)
// {
//     Console.WriteLine($"Number: {a} - max");
// }
// else
// {
//  if ( b > c )
//  {
//         Console.WriteLine($"Number: {b} - max");
//  }
//  else
//  {
//     Console.WriteLine($"Number: {c} - max");
//  }
// }


// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if ( num % 2 == 0)
// {
//     Console.WriteLine($"Your number: {num} - even");
// }
// else
// {
//     Console.WriteLine($"Your number: {num} - odd");
// }


// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Input number N = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The following digits in a row from 1 to {n} are even:");
int current = 1;
while ( current < n )
{
    if ( current % 2 == 0 )
    {
    Console.Write(current + ", ");
    current++;
    }
    else
    {
        current++;
    }
}