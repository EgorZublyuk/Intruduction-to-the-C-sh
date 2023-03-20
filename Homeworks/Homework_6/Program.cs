// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]+ " ");
//     }
//     Console.WriteLine();
// }

// int[] CreateArray(int size)
// {
// int[] Array = new int[size];
// for(int i = 0;i < size; i++)
// {
//     Console.Write($"Input {i} number: ");
//     Array[i] = Convert.ToInt32(Console.ReadLine());
// }
// return Array;
// }

// int QuantityPositiveNum(int[] array)
// {
// int sumPosit = 0;
// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i] > 0) sumPosit++;
// }
// return sumPosit;
// }

// Console.Write("Input quantity numbers in array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] Array = CreateArray(size);
// PrintArray(Array);

// Console.WriteLine($"Numbers more 0: {QuantityPositiveNum(Array)}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y1 = k1 * x + b1, y2 = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void IntersectionPoint(double a1, double b1, double a2, double b2)
{
double tempX = (b2-b1)/(a1-a2);
double tempY = (a1*tempX) + b1;
Console.WriteLine($"Point intersection lines: ({tempX}, {tempY})");
}

Console.Write("Input k for first line:");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b for first line:");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k for second line:");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b for second line:");
double b2 = Convert.ToInt32(Console.ReadLine());
IntersectionPoint(k1, b1, k2, b2);
