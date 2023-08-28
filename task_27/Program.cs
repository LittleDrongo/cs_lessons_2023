// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

StartSumDigitNumber();

void StartSumDigitNumber()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Сумма цифр числа {number} равна {SumDigitNumber (number)}");
}


int SumDigitNumber(int num)
{
    int lastDigit = 0;
    int result = 0;
    while (num > 0)
    {
        lastDigit = num % 10;
        result = lastDigit + result;
        num = num / 10;
    }
    return result;
}