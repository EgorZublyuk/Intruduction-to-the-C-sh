// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



int[,] Create2DRandomArray(int rows, int columns, int minValue,int maxValue)
{
    int [,] array = new int[rows, columns];
    for(int i = 0; i < rows;i++)
    {
        for(int j = 0; j < columns;j++)
        {
            array[i,j] = new Random().Next(minValue,maxValue + 1);
        }
    }
    return array;
}

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Console.WriteLine ("Input number rows array:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input number columns array:");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int [,] myArray = Create2DRandomArray(rows,columns,minValue,maxValue);
// Show2DArray(myArray);

//  int[,] LowToHigh(int[,] array)
// {
//     int min = 0;
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             min = array[i,j];
//             for(int c = j+1; c < array.GetLength(1); c++)
//             {
//                 if(min > array[i,c])
//                 {
//                     array[i,j] = array[i,c];
//                     array[i,c] = min;
//                     min = array[i,j];
//                 }
//             }
//         }
//     }
//     return array;
// }

// myArray = LowToHigh(myArray);
// Show2DArray(myArray);



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int RowWithMinSumElements (int [,] array)
// {
//     int [] arraySumRow = new int[array.GetLength(0)];
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i,j];
//         }
//         arraySumRow[i] = sum;
//     }
//     int min = arraySumRow[0];
//     int current = 0;
//     for(int i = 1; i < arraySumRow.Length; i++)
//     {
//         if( min > arraySumRow[i])
//         {
//             min = arraySumRow[i];
//             current = i+1;
//         }
//     }
//     Console.WriteLine($"Minimal summ number int the {current} rows and this summ: {min}");
//     return current;
// }
// int minRow = 0;
// minRow = RowWithMinSumElements(myArray);



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] CompositionArray (int[,] firstArray, int[,] secondArray)
{
    int [,] SummArray = new int[firstArray.GetLength(0),secondArray.GetLength(1)];
    for(int i = 0; i < SummArray.GetLength(0); i++)
    {
        for(int j = 0; j < SummArray.GetLength(1); j++)
        {   
            int a = 0;
            for(int b = 0; b < SummArray.GetLength(1); b++)
            {
                if(a >= firstArray.GetLength(1))
                {
                    a = 0;
                }
                SummArray[i,j] += firstArray[i,a] * secondArray[b,j];
                a++;
            }
        }
    }
    return SummArray;
}

Console.WriteLine ("Input number rows in first array:");
int firstRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input number columns in first array:");
int firstColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input number rows in second array:");
int secondRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input number columns in second array:");
int secondColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input minimal value of all array element:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input maximal value of all array element:");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,] firstArray = Create2DRandomArray(firstRows,firstColumns,minValue,maxValue);
Show2DArray(firstArray);
int [,] secondArray = Create2DRandomArray(secondRows,secondColumns,minValue,maxValue);
Show2DArray(secondArray);

int[,] compArray = CompositionArray(firstArray,secondArray);
Show2DArray(compArray);













// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



// int[,,] Create3DArrayFor2thNumbersDigit (int rows, int columns, int Whelths)
// {
// int[,,] array = new int [rows, columns, Whelths];

// {
    
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
        
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             for(int g = 0; g < array.GetLength(2); g++)
//             {
//                 int temp = 0;
//                 FillingTheElements:
//                 array[i,j,g] = new Random().Next(10,100);
//                 for(int a = 0; a < i; a++)
//                 {
//                     for(int b = 0; b < j; b++)
//                     {
//                         for(int c = 0; c < g; c++)
//                         {
//                             if(array[i,j,g] == array[a,b,c])
//                             {
//                                 temp++;
//                                 goto FillingTheElements;
                                
//                             }
//                         }
//                     }
//                 }
//             }
//         }
//     }
// }
// return array;
// }

// void Show3DArrayWithIndex (int[,,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             for(int g = 0; g < array.GetLength(2); g++)
//             {
//                 Console.Write($"{array[i,j,g]}({i},{j},{g}) ");
//             }
//             Console.WriteLine();
//         }
        
//     }
// }

// Console.WriteLine ("Input number rows array: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input number columns array: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input number whelths array: ");
// int whelths = Convert.ToInt32(Console.ReadLine());

// int [,,] my3DArray = Create3DArrayFor2thNumbersDigit(rows, columns, whelths);
// Show3DArrayWithIndex(my3DArray);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07















// Итоговое задание по рекурсии!

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29