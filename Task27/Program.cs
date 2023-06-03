
// Задача 27: Напишите программу, которая 
// принимает на вход число и
//  выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumDigit(number);
Console.WriteLine($"Сумма цифр в числе '{number}' -> {sumNumbers}");

int SumDigit(int num) // num = number
{
    if (num <= 0)
    {
        num = num * (-1);
    }
    else num = num * 1;

    int remainder = num % 10;
    int sum = 0;
    while (num > 10)
    {
        int remainder1 = num / 10 % 10;
        sum = sum + remainder1; // sum += remainder1
        num /= 10;
    }
    sum = sum + remainder;
    return sum;
}



// int number = 452;
//  int sumDigit = 0;
// int remainder = number % 10;

//  int remainder2 = number /10 % 10;
//  int remainder3 = number /100 % 10;
// Console.WriteLine ($"{remainder}, {remainder2} -> {remainder3}");

