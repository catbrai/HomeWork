// Задача 25: Напишите цикл, который
// принимает на вход два числа (A и B) и
//  возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число: ");
int numberB = Convert.ToInt32(Console.ReadLine());


int naturalDegree = NaturalDegree(numberA, numberB);
if(numberB <= 0) Console.WriteLine("Вы ввели ненатуральное число.");
else
Console.WriteLine($"{numberA}, {numberB} -> {naturalDegree}");

int NaturalDegree(double numA, double numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result = (int)Math.Pow(numA, numB); //преобразование в (int) - неявное приведение типов
    }
     return result;
}

// int numberA = 2;
// int numberB = 4;

// double pow = Math.Pow(numberA, numberB);
// Console.WriteLine($"{numberA}, {numberB} -> {pow}");