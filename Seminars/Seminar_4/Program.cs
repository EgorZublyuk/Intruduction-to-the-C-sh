// Задача №1 Напишите программу, которая выводит массив из 8 (или любого) количества элементов, заполненный 0 и 1 (илю заданным диапозоном)
// [1,0,1,0,1,1,0,1]

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

// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// ShowArray(CreateRandomArray(size, minValue, maxValue));



//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4  -> 24
//5  -> 120

// int Sum(int N)
// {
//     int sum = 1;
//     for(int i = 1; i <= N; i++)
//     {
//         sum = sum * i;
//     }
//   return sum;
// }
// Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Sum(n));

//Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе. TubNine AI
//456 -> 3
//78 -> 2
//89126 -> 5

int NumOfDig(int num)
{
    int current = 0;
    while( num > 0)
    {
        if( num > 10)
        {
            num = num / 10;
            current++;
        }
        else 
        {
            current++;
            break;
        }
    }
    return current;
}

Console.Write("Input any multiple number: ");
//int dig = Convert.ToInt32(Console.ReadLine());
int dig = new Random().Next(1,1000000+1);
Console.WriteLine(dig);
Console.WriteLine(NumOfDig(dig));
