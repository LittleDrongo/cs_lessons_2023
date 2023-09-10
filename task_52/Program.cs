/*
Задача 52: Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце. 
Например, задан массив: 
1 4 7 2 
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

void PrintArray2D(int[,] matrix)
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

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]:F1}, ");
        else Console.Write($"{arr[i],5:F1}");
    }
    Console.Write("]");
}


double[] FindArray2DColumnAVG (int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    double[] arr = new double[columns];
    double sumColumns = 0;

    for (int i = 0; i < columns; i++)
    {
        sumColumns = 0;
        for (int j = 0; j < rows; j++)
        {
            sumColumns += matrix[j,i];
        }
        arr[i] = sumColumns/rows;
    }
    return arr;
}


int[,] array2d = CreateMatrixRndInt(2, 10, 0, 10);
double[] arrayDouble = FindArray2DColumnAVG(array2d);
PrintArray2D(array2d);
Console.WriteLine();
PrintArrayDouble(arrayDouble);
Console.WriteLine();