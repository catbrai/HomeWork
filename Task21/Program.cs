// Задача 21
// Напишите программу, которая 
// принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int EnterCoordinate(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double Distance(int x1, int y1,int z1, int x2, int y2, int z2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
}


int xOfA = EnterCoordinate("Введите Х для точки A");
int yOfA = EnterCoordinate("Введите У для точки A");
int zOfA = EnterCoordinate("Введите Z для точки A");
int xOfB = EnterCoordinate("Введите Х для точки В");
int yOfB = EnterCoordinate("Введите У для точки В");
int zOfB = EnterCoordinate("Введите Z для точки B");

double result = Distance(xOfA, yOfA, zOfA, xOfB, yOfB, zOfB);

System.Console.WriteLine
($"Расстояние между точками A и B в 3D пространстве -  ");
System.Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero));
