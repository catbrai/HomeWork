// Задача 34: Задайте массив ,заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
       Console.Write($"{arr[i]}, ");
     }
     Console.Write($"{arr[arr.Length - 1]}]");
}

int SumEvenElements(int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
      if (arr[i] % 2 == 0) sum += 1; 
    }
    return sum;
}

int [] array = CreateArrayRndInt(10);
PrintArray(array);
Console.WriteLine();
int sumNumbers = SumEvenElements(array);
Console.WriteLine($"Количество четных чисел в массиве: {sumNumbers}");

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int number1 = number % 2;
// Console.WriteLine(number1); // определение на четность number % 2 == 0 (четное), number % 2 ==1 (нечетное)
