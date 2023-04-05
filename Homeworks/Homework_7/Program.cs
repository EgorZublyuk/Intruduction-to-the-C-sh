
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double [,] CreateRandom2DRealArray (int rows, int columns, int minValue, int maxValue)
// {
//     double [,] array = new double [rows, columns];
//     for(int i=0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] =  new Random().Next(minValue, maxValue+1) + Math.Round(new Random().NextDouble(), 2);
//         }
//     }
//     return array;
// }

// void Print2DRealArray(double [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Input the numbers of rows in array: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the numbers of columns in array: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minimal value of numbers: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input maximal value of numbers: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// double [,] myArray = CreateRandom2DRealArray(rows, columns, minValue, maxValue);
// Print2DRealArray(myArray);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

// void CheckElementsOf2DArray(int [,] array, int row, int column)
// {
//     int end = 0;
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             if( row == i && column == j)
//             {
//                 Console.WriteLine($"Your array elements: {array[i,j]}");
//                 end++;
//             }
//         }
//     }
//     if(end == 0)
//     Console.WriteLine($"({row}, {column}) - This is element don't exists.");
// }

Console.Write("Input the numbers of rows in array: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the numbers of columns in array: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimal value of numbers: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximal value of numbers: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);
Show2DArray(myArray);

// Console.Write("Input the numbers of row in array: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the numbers of column in array: ");
// int column = Convert.ToInt32(Console.ReadLine());
// CheckElementsOf2DArray(myArray, row, column);



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[] ArithmeticMeanColumns (int[,] array)
{
double [] columnsArray = new double [array.GetLength(1)];
int current = 0;
double MeanCoulmns = 0;
for(int i = 0; i < array.GetLength(0);i++)
    {
        MeanCoulmns = 0;
        for(int j = 0; j < array.GetLength(1);j++)
        {
            MeanCoulmns += array[j,i];
         
        }
        MeanCoulmns = MeanCoulmns / array.GetLength(0);
        columnsArray[i] = MeanCoulmns;
        current++;
    }
return columnsArray;
}

void PrintRealArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
}

double[] columnsMeanArray = ArithmeticMeanColumns(myArray);
PrintRealArray(columnsMeanArray);