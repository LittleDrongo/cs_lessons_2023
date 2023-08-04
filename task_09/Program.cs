// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100); // 99+1
Console.WriteLine($"Случайное число в диапазоне 10 - 99 -> {number}");
// int firstDigit = number / 10; //78 / 10 = 7.8
// int secondDigit = number % 10; //Остаток от деления 78 % 10 = 70 + 8

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра чиасла - {firstDigit}");
// else
// {
//     Console.WriteLine($"Наибольшая цифра чиасла - {secondDigit}");
// }

// int result = firstDigit > secondDigit ? firstDigit : secondDigit;
// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра чиасла - {result}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Случайное число в диапазоне 10 - 99 -> {maxDigit}");

int maxDigit1 = MaxDigit(56);
Console.WriteLine($"Случайное число в диапазоне 10 - 99 -> {maxDigit1}");

int maxDigit2 = MaxDigit(89);
Console.WriteLine($"Случайное число в диапазоне 10 - 99 -> {maxDigit2}");


int MaxDigit(int num)
{
    int firstDigit = num / 10; //78 / 10 = 7.8
    int secondDigit = num % 10; //Остаток от деления 78 % 10 = 70 + 8
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}