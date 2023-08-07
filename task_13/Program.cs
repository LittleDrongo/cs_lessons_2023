// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//зациклить делением (!)
//Получить трёхзначное число в цикле

Console.WriteLine("Введите любое число от 100 до 2147483647");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("Ошибка ввода, число должно быть трёхзначным и более");
}
else
{
    int resultNumber = FindThirdNumber(number);
    Console.WriteLine(resultNumber);
}

int FindThirdNumber(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    num = num % 10;
    return num;
}