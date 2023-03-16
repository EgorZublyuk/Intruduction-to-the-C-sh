//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return newArray;
}

void ShowArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }
    Console.WriteLine ();
}

void FindSum (int[] array)
{
    int sumPos = 0;
    int sumNeg = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0) sumPos += array[i];
        else sumNeg += array[i];
    }
    Console.WriteLine($"Sum of positive digits is -> {sumPos}, sum of negativ digits is -> {sumNeg} ");
}

Console.WriteLine ("Input array size:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input minimal value of array element:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input maximal value of array element:");
int maxValue = Convert.ToInt32(Console.ReadLine());

// ShowArray(CreateRandomArray(size, minValue, maxValue));

// int[] myArray = CreateRandomArray (size,minValue, maxValue);
// FindSum (myArray);

// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return newArray;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write (array[i] + " ");
//     }
//     Console.WriteLine ();
// }

// void FindSum (int[] array)
// {
//     int sumPos = 0;
//     int sumNeg = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] >= 0) sumPos += array[i];
//         else sumNeg += array[i];
//     }

//     Console.WriteLine ($"Sum of positive digits is -> {sumPos}, Sum of negative digits is -> {sumNeg}");
// }


// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray (size, minValue, maxValue);
// ShowArray (myArray);

// FindSum (myArray);


//Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] CangeElementsOfArray(int [] array)
// {
//     for(int i = 1; i <= array.Length;i++)
//     {
//         array[i] *= (-1);
//     }
//     return array;
// }
// int[] myArray = CreateRandomArray (size, minValue, maxValue);
// ShowArray(myArray);
// myArray = CangeElementsOfArray(myArray);
// ShowArray(myArray);



//Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// ??????????????????????????????

// bool CangeDigit(int[] array, int num)
// {
//     for(int i = 0; i <= array.Length; i++)
//     {
//         if(array[i] == num) return true;
        
//     }
//     return false;
// }
// int[] myArray = CreateRandomArray (size, minValue, maxValue);
// Console.WriteLine ("Input number for chek:");
// int chek = Convert.ToInt32(Console.ReadLine());
// ShowArray(myArray);
// CangeDigit(myArray, chek);


//Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].

int SearchRange(int[] array, int firstEdge, int secondEdge)
{
    int count = 0;
    for(int i = 0; i <= array.Length; i++)
    {
        if(array[i] >= firstEdge && array[i] <= secondEdge)
        {
        count ++;
        }
    }
    return count;
}

int[] myArray = CreateRandomArray (size, minValue, maxValue);
Console.WriteLine ("Input first limit:");
int firstLimit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input second limit:");
int secondLimit = Convert.ToInt32(Console.ReadLine());
ShowArray(myArray);
int numElements = SearchRange(myArray, firstLimit, secondLimit);
Console.WriteLine(numElements);

// Random().NextDouble()
Clear.Console();
Console.Clear;