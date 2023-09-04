// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10
int DecimalToBinary(int number)
{
    int binary = 0;
    int mult = 1;
    while (number != 0)
    {
        binary += mult * (number % 2); 
        number = number / 2;
        mult *= 10;
    }
    return binary;
}
int binar = DecimalToBinary(2);
Console.WriteLine(binar);