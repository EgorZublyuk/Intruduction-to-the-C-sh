﻿//Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)

//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

int [] CreateRandomArray(int size, int minValue,int maxValue)  //min нижнее ограничение max верхнее ограничение
{
int [] newArray = new int [size]; //тип массива int, выделяем память под тип int size штук 

    for(int i=0;i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray(int [] array)
{
    Console.Write($"Получившийся массив -> ");

    for(int i = 0;i < array.Length;i++ )
    {
        Console.Write (array[i]+" ");
    }
    Console.WriteLine();
}

int[] ReversArray(int [] array)
{
    for(int i = 0; i <array.Length/2; i++)
    {
        int temp = array[i];
        array[i]= array[array.Length-i-1];
        array[array.Length-i-1] = temp;
    }
    return array;
} 


Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
myArray = ReversArray(myArray);
ShowArray(myArray);


//Задача 2.Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//самое важное знать правило, какждая сторона должна быть меньше(строго) суммы двух других сторон

// bool CheckTriangle (int a,int b, int c)
// {
//     if(a+b>c && a+c>b && b+c>a)
//     return true;
//     else return false;
// }

// Console.WriteLine(CheckTriangle(3,4,9));


//Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
//числа фибоначчи последовательность чисел в которой первые 2 числа это 0 и 1, а последубщие это сумма двух передыдущих
//[0,1,1,2, 3, 5, 8, 13, ... ]


// int[] Fibanachi(int N,int a,int b)
// {
    
//     int[] array = new int[N];
//     array[0] = a;
//     array[1] = b;
//     for(int i = 2; i<N;i++)
//     {
//         array[i]= array[i-1] + array[i-2];
//     }
//     return array;
// }


// ShowArray(Fibanachi(11,3,5));


//Задача 4. ****Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10

// void twoInTen(int num)
// {
//     string StringNum = string.Empty;
//     while(num >= 1)
//     {
//         StringNum = num % 2 + StringNum; 
//         num = num / 2;
//     }
//     Console.WriteLine(StringNum);
// }

// int n = Convert.ToInt32(Console.ReadLine());
// twoInTen(n);




// void Fi(int n, int a, int b)
// {
//     int res = 0;
//     for (int i = 0; i < n - 2; i++)

//     {
//         res = a + b;
//         a = b;
//         b = res;
//         Console.Write($"{res} ");
//     }
// }

// Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("First Fi: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Second Fi: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.Write($"{a} {b} ");
// Fi(n, a, b);