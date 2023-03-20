// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < newArray.Length; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return newArray;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine ();
// }

// void FindSum (int[] array)
// {
//     int sumPos = 0;
//     int sumNeg = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 0) sumPos += array[i];
//         else sumNeg += array[i];
//     }
//     Console.WriteLine($"Sum of positive digits is -> {sumPos}, sum of negativ digits is -> {sumNeg} ");
// }


// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array element:");
// int minWhole = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array element:");
// int maxWhole = Convert.ToInt32(Console.ReadLine());

// int ThreeDigitEven (int[] array)
// {
//     int count = 0;
//     for(int i=0;i<array.Length;i++)
//     {
//         if(array[i] % 2 == 0)
//         count++;
//     }
//     return count;
// }

// int[] myArray = CreateRandomArray(size, minWhole, maxWhole);

// ShowArray(myArray);
// Console.WriteLine($"This array has {ThreeDigitEven(myArray)} even numbers");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int SumOddElements (int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i<array.Length;i++)
//     {
//         if(i % 2==1)
//         sum += array[i];
//     }
//     return sum;
// }

// Console.WriteLine($"Sum of the odd elements of this array: {SumOddElements(myArray)}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateRandomRealArray (int size, int minWhole, int maxWhole)
{
    double[] newArray = new double[size];
    for(int i = 0; i < newArray.Length; i++)
    {
    double whole = new Random().Next(minWhole, maxWhole+1);
    double fract = Math.Round(new Random().NextDouble(), 3);
        newArray[i] = whole + fract;
    }
    return newArray;
}

void ShowRealArray (double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine ();
}

Console.WriteLine ("Input array size:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input minimal whole value of array element:");
int minWhole = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input maximal whole value of array element:");
int maxWhole = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomRealArray(size,minWhole,maxWhole);

ShowRealArray(myArray);

double diffMinAndMax(double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i=1;i<array.Length;i++)
    {
        if(array[i]>max) max = array[i];
        if(array[i]<min) min = array[i];
    }
    double diff = max - min;
    return diff; 
}

Console.WriteLine($"Different between the maximum and minimum: {diffMinAndMax(myArray)}");

