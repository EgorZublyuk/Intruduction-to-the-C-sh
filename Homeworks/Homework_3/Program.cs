// Задача № 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// void Palindrom(int num)
// {
//     int FirtFromTheEnd = 0;
//     int SecondFromTheEnd = 0;
//     if( 10000 < num && num < 100000 )
//     {
//         FirtFromTheEnd = num % 10;
//         SecondFromTheEnd = ( num % 100 ) / 10;
//         if ( num / 10000 == FirtFromTheEnd)
//         {
//             if ( (num / 1000) % 10 == SecondFromTheEnd )
//             {
//                 Console.WriteLine("Yes, your number palindrome");
//             }
//             else
//             Console.WriteLine("Sorry, your number is n't palindrome");
//         }
//         else
//             Console.WriteLine("Sorry, your number is n't palindrome");
//     }
//     else Console.WriteLine($"Your number don't fuive digit ");
// }

// Console.Write("Input five-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Palindrom(num);


// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double Distanse(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double dist = 0;
//     dist = Math.Round(Math.Sqrt (Math.Pow (x2 - x1, 2) + Math.Pow (y2 - y1, 2) + Math.Pow (z2 -z1, 2)), 2);
//     return dist;

// }

// Console.Write("Input first coordinate X: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input first coordinate Y: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input first coordinate Z: ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input second coordinate X: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input second coordinate Y: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input second coordinate Z: ");
// double z2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance of the two point: {Distanse(x1, y1, z1, x2, y2, z2)}");


// Задача №3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void TableOfCubes(int num)
{
    for(int i = 1; i <= num; i++)
    {
        Console.Write(Math.Pow(i, 3) + " ");
    }
}

Console.Write("Input number N for cubing: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Cubes from 1 to N: ");
TableOfCubes(n);