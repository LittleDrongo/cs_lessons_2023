// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

bool CheckSquareTwoNumbers(int firstNumber, int secondNumber)
{
    return firstNumber * firstNumber == secondNumber || secondNumber * secondNumber == firstNumber;
}

Console.WriteLine("Please input two numbers");
int num1=Convert.ToInt32(Console.ReadLine());
int num2=Convert.ToInt32(Console.ReadLine());

bool result = CheckSquareTwoNumbers(num1, num2);
Console.WriteLine(result? "Yes" : "No");