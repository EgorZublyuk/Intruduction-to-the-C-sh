// Задача № 1 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int TwoDigits(int number)
// {
//     number = (number / 10 ) % 10;
//     return number;
// }
// int random = new Random().Next(100, 1000);
// Console.WriteLine($"Number - {random}");
// Console.WriteLine("Second digit - " + TwoDigits(random));


// Задача № 2 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int num = new Random().Next(10, 10000);
// Console.WriteLine($"Your number - {num}");

// int ThirdDigit(int number)
// {

//     while ( number > 99)
//     {
//         if ( number < 999)
//         {
//             number = number % 10;
//             break;
//         }
//         else
//         {
//             number = number / 10;
//         }
        
//     }
//     return number;
// }

// if ( num > 99 )
//     Console.WriteLine($"Third digit - {ThirdDigit(num)}");
//     else
//     Console.WriteLine($"Your number - {num} does n't contain the third digit");


// Задача № 3 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool Weekend(int day)
{
    return(day == 7 || day == 6);
//     if ( day == 7 || day == 6)
//     {
//         return Console.WriteLine("Yes");
//     }
//     else return Console.WriteLine("No");
}

int dayWeek = new Random().Next(1, 8);
Console.WriteLine($"Your day of week - {dayWeek}");
Console.WriteLine($"This day weekend? {Weekend(dayWeek)}");

