// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max, int round = 2)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;// задает нужный диапазон
        arr[i] = Math.Round(num, round);
    }

    return arr;
}

void PrintArrayDouble(double[] arr, string sep = ",")
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}]");
    }
}

double FindMax (double[] arr)
{
double max1 = arr[0];
for (int i = 0; i < arr.Length; i++)
{
   if (arr[i] > max1) max1 = arr[i];  
}
return max1;
}

double FindMin (double[] arr)
{
 double min1 = arr[0];
for (int i = 0; i < arr.Length; i++)
{
   if (arr[i] < min1) min1 = arr[i];  
}
return min1;   
}

double MaxMinDiff (double max1, double min1) 
{
double num = max1 - min1;
return num;
}

double [] array = CreateArrayRndDouble(5, 1, 10);
PrintArrayDouble(array, ";");

double max = FindMax (array);
double min = FindMin (array);

double maxMinDiff = MaxMinDiff (max, min);
Console.Write($" -> {max} - {min} = {maxMinDiff}");