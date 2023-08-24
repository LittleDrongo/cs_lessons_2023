// Задача 23: Напишите программу которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Пример:
// 3 -> 1,8,27
// 5 -> 1,8,27,64,125
Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
CubesNumber (number);

void CubesNumber (int num)
{
    Console.WriteLine();
    Console.WriteLine($"Таблица кубов числа: {num}");
    for (int i = 1; i-1 < num; i++)
    {
        Console.WriteLine(i*i*i);
    } 
}