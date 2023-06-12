// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write("Введите элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
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

int SumPositiveNumber(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum = sum + 1;
    }
    return sum;
}

Console.Write("Введите количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size);
PrintArray(array);

int sumPositiveNumber = SumPositiveNumber (array);
if (sumPositiveNumber == 1) Console.Write($"Вы ввели '{sumPositiveNumber}' число больше 0.");
if (sumPositiveNumber == 2 || sumPositiveNumber == 3 || sumPositiveNumber == 4)
           Console.Write($"Вы ввели '{sumPositiveNumber}' числа больше 0.");
if (sumPositiveNumber > 4) Console.Write($"Вы ввели '{sumPositiveNumber}' чисел больше 0.");
