﻿// Задача 4: Напишите программу, 
// которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число:");
int numberD = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberB > max) max = numberB;
if (numberD > max) max = numberD;

    Console.Write("Максимальное число = " + max);
   