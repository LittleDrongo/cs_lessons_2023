// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int Remainder(int first, int second)
{
    return first % second;
}

Console.WriteLine("Введите два числа");
int firstDigit = Convert.ToInt32(Console.ReadLine());
int secondDigit = Convert.ToInt32(Console.ReadLine());

int remainder = Remainder(firstDigit, secondDigit);
// if (remainder == 0)
//     Console.WriteLine("Кратно");
// else
//     Console.WriteLine($"Не кратно, остаток:{remainder}");

Console.WriteLine(remainder == 0 ? "Кратно" : $"Не кратно, остаток:{remainder}");