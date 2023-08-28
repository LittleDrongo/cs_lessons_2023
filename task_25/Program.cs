// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
StartRaiseNaturalNumber();

void StartRaiseNaturalNumber()
{
    Console.WriteLine("Введите два числа");
    Console.Write("Введите число А: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число Б: ");
    int degree = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Возведенное число {number} в натуральную степень {degree} равен {RaiseNaturalNumber(number, degree)}");
}

int RaiseNaturalNumber(int num, int deg)
{
    int res = 1;
    for (int i = 0; i < deg; i++)
    {
        res = res * num;
    }
    return res;
}