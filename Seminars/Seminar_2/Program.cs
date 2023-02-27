// Задача № 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8
// int BiggestDigit (int num)
// {
//     int et = num % 10;
//     int dec = num / 10;
//     if (dec > et)
//         return dec;
//     else return et;
// }

// int randomnum = new Random().Next(10, 100);
// int res = BiggestDigit(randomnum);
// Console.Write($"Biggest digit of {randomnum} -> {res}");


// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int DelitDigit(int num)
// {
//     int sot = num / 100;
//     int ed = num % 10;
//     return sot * 10 + ed;
// }
// int ramdomnum = new Random().Next(100,1000);
// Console.WriteLine(ramdomnum);
// Console.WriteLine(DelitDigit(ramdomnum));


// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14  ->  нет
// 46  ->  нет
// 161 ->  да

// bool Number7_23(int num)
// {
//    if(num % 7 == 0 && num % 23 == 0)
//    return true;
//    else return false;
// }

// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Number multipl 7 and 23 ? {Number7_23(num)}");


// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

bool MultiplNumbers(double num1, double num2)
{
    // if(num1 / num2 == num2 || num2 / num1 == num1)
    // return true;
    // else return false;
    return (num1 / num2 == num2 || num2 / num1 == num1);
} 

// int firstRandom = new Random().Next(1, 100);
// Console.WriteLine(firstRandom);
// int secondRandom = new Random().Next(1, 100);
// Console.WriteLine(secondRandom);
// Console.WriteLine(MultiplNumbers(firstRandom, secondRandom));


Console.Write("Input number one: ");
double firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number two: ");
double secondNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Number multipl first on second ? {MultiplNumbers(firstNum, secondNum)}");