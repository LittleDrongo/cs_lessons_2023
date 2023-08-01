Console.WriteLine("Ведите натуральное число N");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    Console.Write("Введено некорректное число.");
}
else
{
    int count = -number;
    while (count <= number)
    {
        Console.Write($"{count} ");
        count += 1;
    }
}