// Задача 19: Напишите программу, которая принимает на вход пятизначное число и провеят является ли оно палиндромом. 
// Пример 1421 -> нет
// Пример 23432 -> да
// Пример 12821 -> да

StartCheckPalindrom();

void StartCheckPalindrom()
{
    Console.WriteLine ("Введите пятизначное число");
    int fiveDigitNumber = Convert.ToInt32(Console.ReadLine());
    CheckPalindrom(fiveDigitNumber);
}


bool CheckPalindrom(int num)
{
    if (num < 9999 || num > 10000)
    {
        if (num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10)
        {
            Console.WriteLine("Отладочное сообщение: Истина");
            return true;            
        }
        else
        {
            Console.WriteLine("Отладочное сообщение: Ложь");
            return false;
        }
    }
    else
    {
        Console.WriteLine("Отладочное сообщение: Ложь");
        return false;
    }
}