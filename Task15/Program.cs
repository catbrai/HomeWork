// 15: Напишите программу, которая
//   принимает на вход цифру,
//   обозначающую день недели, и 
//    проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число, соответствующее дню недели: ");
int number = Convert.ToInt32(Console.ReadLine());
int dayOfWeek = DayOfWeek(number);

if (number >= 1 && number <= 7) Console.WriteLine(dayOfWeek);
else 
if (number < 0 || number >= 8)  Console.Write("Некорректный ввод.");

int DayOfWeek(int day)
{
    if (number == 6) Console.WriteLine("Да, это выходной.");
    else
    if (number == 7) Console.WriteLine("Да, это выходной.");
    else
    if (number >= 1 && number < 6)  Console.WriteLine("Нет, это не выходной.");
    return day;
}