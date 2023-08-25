// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет является ли оно палиндромом. 
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
            Console.WriteLine("Истина: число является палиндромом");
            return true;            
        }
        else
        {
            Console.WriteLine("Ложь: число является палиндромом");
            return false;
        }
    }
    else
    {
        Console.WriteLine("Ложь: Число не является пятизначным");
        return false;
    }
}