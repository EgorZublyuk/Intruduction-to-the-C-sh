//Задание1.  Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// int FindQuart (int x, int y)
// {
//     if ( x > 0 && y > 0 )
//     return 1;
//     if ( x < 0 && y > 0 )
//     return 2;
//     if ( x < 0 && y < 0 )
//     return 3;
//     if ( x > 0 && y < 0 )
//     return 4;

//     return 0;
// }

// Console.Write("Input X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input Y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Point located at {FindQuart(x, y)} quart");


//Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

// double FindDistance(double x1, double y1, double x2, double y2)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2)), 2);
// }

// Console.Write("Input coordinate X of A point: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input coordinate Y of A point: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input coordinate X of B point: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input coordinate Y of B point: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// double distance = FindDistance(x1, y1, x2, y2);
// Console.WriteLine($"Distance between A and B is {distance}");


//Задача 2.Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

// void QuartDia(int quart)
// {
//         if ( quart == 1 )
//      Console.WriteLine("Y > 0, X > 0");
//     if ( quart == 2 )
//      Console.WriteLine("Y > 0, X < 0");
//     if ( quart == 3 )
//      Console.WriteLine("Y < 0, X < 0");
//     if ( quart == 4 )
//      Console.WriteLine("Y < 0, X > 0");
    
//      if (quart < 1 || quart > 4)
//      Console.WriteLine("error");
// }
// int quart = Convert.ToInt32(Console.ReadLine());
// QuartDia(quart);


//Задача 4. Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N

void Qadro(int num)
{
    int current = 1;
    while (current <= num)
    {
        Console.Write((current*current) + " ");
        current++;
    }
}

int num = Convert.ToInt32(Console.ReadLine());
Qadro(num);
