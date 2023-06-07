// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов (от 1 до 8) 
// и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length ; i++)
    {
          if (i < array.Length - 1) Console.Write($"{array[i]}, ");
          else Console.Write($"{array[i]}");
    }
   }

int x = new Random().Next(1,7);
int[] array1 = new int[x];
FillArray(array1);
Console.Write("[");
PrintArray(array1);
Console.Write("]");


