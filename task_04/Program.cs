﻿/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
//if (number >= 100 && number <= 999)

Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int maxNumber = firstNumber;
if (maxNumber < secondNumber)
{
    maxNumber = secondNumber;
} if (maxNumber < thirdNumber)
{
    maxNumber = thirdNumber;
} else

Console.WriteLine("--------------------");
Console.WriteLine($"Максимальное число: {maxNumber}");