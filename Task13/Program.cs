// 13: Напишите программу, которая 
// выводит третью цифру заданного числа или
//  сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number < 100) Console.WriteLine("Третьей цифры нет");

// else
//     while (number > 1000)
//     {
//         number = number / 10;
//     }

// if (number > 100 && number < 1000)
// {
//     int threeDigitNumber = number % 10;
//     Console.WriteLine($"Третья цифра числа {threeDigitNumber}");
// }

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number > 1000 || number < -1000)
{
    number = number / 10;
}

int threeDigitNumber = ThreeDigitNumber(number);

if (number < 100 && number > -99) Console.WriteLine("Третьей цифры нет");

else 
if (number >= 100 && number <= 999)
    Console.WriteLine($"Третья цифра числа {threeDigitNumber}");

else if (number <= -100 && number >= -999)
{
    threeDigitNumber = threeDigitNumber * (-1);
     Console.WriteLine($"Третья цифра числа {threeDigitNumber}");
}

int ThreeDigitNumber(int num)
{
    return threeDigitNumber = num % 10;
}


