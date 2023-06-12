/*
Задача 43: Напишите программу, которая
найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
 значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int GetNumber(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}


void IntersectionPoint(double bb1, double kk1, double bb2, double kk2, int round = 1)
{
    double xx = (bb2 - bb1) / (kk1 - kk2);
    double x = Math.Round(xx, round);

    double yy = kk1 * x + bb1;
    double y = Math.Round(yy, round);

    double firstLine = -y + kk1 * x + bb1;
    double secondLine = -y + kk2 * x + bb2;

    if (firstLine == 0 && secondLine == 0)
        Console.WriteLine($" Координаты точки пересечения двух линий ({x}; {y}).");
    else if (kk1 == kk2) Console.WriteLine($"Прямые параллельны.");
    else if (kk1 == kk2 && bb1 == bb2) Console.WriteLine($"Прямые совпадают.");
}



int b1 = GetNumber("Число b1: ");
int k1 = GetNumber("Число k1: ");
int b2 = GetNumber("Число b2: ");
int k2 = GetNumber("Число k2: ");

IntersectionPoint(b1, k1, b2, k2);




