// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, заполненный псеводослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
GenerateRandomArray(array);
ShowRandomArray(array);

void GenerateRandomArray(int[] arr)
{
    int i = 0;
    var random = new Random();
    while (i < arr.Length)
    {
        arr[i] = random.Next(50);
        i++;
    }
}

void ShowRandomArray(int[] arr)
{
    int i = 0;
    Console.Write("[");
    while (i < arr.Length)
    {
        if (i < arr.Length - 1)
        {
            Console.Write($"{arr[i]}, ");
            i++;
        }
        else
        {
            Console.Write($"{arr[i]}");
            i++;
        }
    }
    Console.Write("]");
}