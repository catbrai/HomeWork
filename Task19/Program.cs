// Задача 19
// Напишите программу, которая 
// принимает на вход пятизначное число и
//  проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool palindrom = Palindrom(number);

if (number > -9999 && number < 10000 || number > 99999 || number < -99999)
    Console.Write("Вы ввели не пятизначное число.");

else
    Console.WriteLine(palindrom ? "да, это палиндром." : "нет, это не палиндром.");

bool Palindrom(int num)
{ 
    int firstNumber = num / 10000;
    int lastNumber = num % 10;
    int secondNumber = num / 1000 % 10;
    int fourNumber = num % 100 / 10;
    bool result = (firstNumber == lastNumber && secondNumber == fourNumber) ? true: false;
    return result;
}        
//======================================================= 1 variant
// Console.Write("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int firstNumber = number / 10000;
// int lastNumber = number % 10;
// int secondNumber = number / 1000 % 10;
// int fourNumber = number % 100 / 10;


// if (number < 10000 || number > 99999) Console.Write("Вы ввели не пятизначное число.");

// else if (number >= 10000 && number <= 99999)
// {
//     if (firstNumber == lastNumber && secondNumber == fourNumber)
//         Console.WriteLine("Да, это палиндром");

//     else
//         Console.WriteLine("Нет, это не палиндром");
// }


