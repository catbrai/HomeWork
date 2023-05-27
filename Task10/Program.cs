//10: Напишите программу, которая
// принимает на вход трёхзначное число и
//на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");                     //ввод данных
int number = Convert.ToInt32(Console.ReadLine());                 //переменные

int showSecondDigit = ShowSecondDigit(number);

if (number < 100 && number > -100) 
Console.WriteLine ("Вы ввели не трехзначное число.");

else if (number > 999 || number < - 999)
Console.WriteLine ("Вы ввели не трехзначное число.");

else
Console.WriteLine($"Вторая цифра числа {showSecondDigit}");


int ShowSecondDigit(int num)                                   // метод
{
    int remainder = (num % 100 ) / 10;  // remainder - остаток
    return remainder = remainder < 0 ? remainder * (-1) : remainder ;
}


