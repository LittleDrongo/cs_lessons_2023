// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("День недели в формате 1 - 7");
int day = Convert.ToInt32(Console.ReadLine());
string isWeekend = DayWeek(day);
Console.WriteLine(isWeekend);
string DayWeek (int num)
{
    if (num > 0 & num < 8)
    {
        return num > 5 ? $"{num}-й день недели — выходной" : $"{num}-й день недели — будень";
    }
    else 
    {
        return "Ошибка: неверно введен день недели, введите значение в диапазоне 1-7.";
    }
}