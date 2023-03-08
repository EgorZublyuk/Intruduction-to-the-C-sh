
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Degree(int num1, int num2)
// {
//     int sum = 1;
//     for( int i = 1; i <= num2;i++)
//     {
//         sum = sum * num1;
//     }
//     return sum;
// }

// Console.Write("Input number to raise to a power: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Inpute degree: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Result: {Degree(a, b)}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumNumbers(int num)
// {
//     int sum = 0;
//     while(num > 0)
//     {
//         sum = num % 10 + sum;
//         num = num / 10;
//     }
//     return sum;
// }
// int random = new Random().Next(1,10001);
// Console.WriteLine($"Number: {random}");
// Console.WriteLine($"Sum digit: {SumNumbers(random)}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateRandomArray(int size, int minDigit, int maxDigit)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minDigit,maxDigit+1);
    }
    return newArray;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
}
Console.Write("Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimum value array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum value array: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, min, max);
PrintArray(array);
