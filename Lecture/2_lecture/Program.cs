// Лекция № 2
// Обучение работе с функциями (методами)
// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2 > result) result = arg2;
//     if(arg3 > result) result = arg3;
//     return result;
// }
// int[] array = { 11, 54, 32, 77, 63, 33, 202, 41, 55 };

// int max1 = Max(array[0], array[1], array[2]);
// int max2 = Max(array[3], array[4], array[5]);
// int max3 = Max(array[6], array[7], array[8]);
// int max = Max(max1, max2, max3);

// int max = Max(
//             Max(array[0], array[1], array[2]), 
//             Max(array[3], array[4], array[5]), 
//             Max(array[6], array[7], array[8])
//             );

// Console.WriteLine(max);

// Проверка совподения введённого числа с числом из массива и вывод его намера по порядку

// int[] array = {15, 23, 83, 54, 65, 36, 47, 18};

// int n = array.Length;
// int find = 54;

// int index = 0;

// while (index < n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine(index);
//         break; // Условие прерывания цыкла 
//     }
//     index++;
// }

// Собираем массив заполняющейся случайными числами
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while ( position < count )
    {
        Console.Write(coll[position] + ", ");
        position++;
    }
}
int Eqaul(int[] collect, int find)
{
    int lenght = collect.Length;
    int index = 0;
    int position = -1;
    while (index < lenght)
    {
        if (collect[index] == find);
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
array[2] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int find = 4;

int equal = Eqaul(array, find);
Console.WriteLine(equal);


