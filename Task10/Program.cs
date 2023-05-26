//10: Напишите программу, которая
// принимает на вход трёхзначное число и
//на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите целое положительное трехзначное число: "); //ввод данных
int number = Convert.ToInt32(Console.ReadLine());                 //переменные

int showSecondDigit = ShowSecondDigit(number);

if (number > 100 && number < 1000)                               // условие
{
    Console.WriteLine($"Вторая цифра числа {showSecondDigit}");
}
else
    Console.WriteLine("Некорректный ввод");
    

int ShowSecondDigit(int num)                                   // метод
{
    int remainder = number % 100; // remainder - остаток
    return remainder / 10 ;
}


