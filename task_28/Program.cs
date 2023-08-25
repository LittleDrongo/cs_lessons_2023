// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int MultiplicationNums(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            mult *= i;
        }
    }
    return mult;
}

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine($"{number} -> не корректное чило");
}

else
{
    int multNums = MultiplicationNums(number);
    Console.WriteLine($"{multNums} -> произведения чисел от 1 до {number}");
}