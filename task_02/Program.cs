/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введита второе число");
int numberTwo = Convert.ToInt32(Console.ReadLine());


if (numberOne > numberTwo)
{
    int maxNumber = numberOne;
    int minNumber = numberTwo;
    Console.WriteLine($"Большое число: {maxNumber}, меньшее число: {minNumber}");
} else
{
    int maxNumber = numberTwo;
    int minNumber = numberOne;
    Console.WriteLine($"Большое число: {maxNumber}, меньшее число: {minNumber}");
}

