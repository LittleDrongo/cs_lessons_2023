/* 
    Задача 50:Напишите программу, которая на вход принимает позиции 
    элемента в двумерном массиве, и возвращает значение этого элемента 
    или же указание, что такого элемента нет. 
    Например, задан массив: 
    1 4 7 2 
    5 9 2 3 
    8 4 2 4 

    17 -> такого числа в массиве нет
*/


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

int ReturnValueByPosition2D(int[,] matrix, int row, int column)
{
    return (matrix[row, column]);
}

void FindNumberByPosition2D(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    Console.WriteLine("Введите координаты");
    Console.Write("Введите номер строки: ");
    int row = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите номер столбца: ");
    int column = Convert.ToInt32(Console.ReadLine());

    if (row < 0 || column < 0)
    {
        Console.WriteLine("Ошибка: Значение не должно быть меньше нуля");
    }
    else
    {
        if (row > rows || column > columns)
        {
            Console.WriteLine("Такой позиции в двумерном массиве нет");
        }
        else
        {
            Console.WriteLine($"Значение в указанных координатах: {ReturnValueByPosition2D(matrix, row, column)}");
        }
    }
}

int[,] array2d = CreateMatrixRndInt(5, 5, 0, 10);
PrintArray(array2d);

FindNumberByPosition2D(array2d);
Console.WriteLine();
