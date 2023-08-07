// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int SecondDigit(int num)
{
    num = num / 10 % 10;
    return num;
}

Console.WriteLine ("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 & number < 1000)
{
    int secondDigit = SecondDigit(number);
    Console.WriteLine (secondDigit);
}
else
{
    Console.WriteLine ("Некорректный ввод");
}