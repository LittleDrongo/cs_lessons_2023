// Задача 47:
// Задайте двумерный массив размером м*н
// Заполненный случайными вещественными числами.

// м = 3, н = 4
// 0.5     -2      -0.2
// 1       -3.3    -9.9
// 8       7.8     -7.1

double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max) 
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return matrix;
}

void PrintMatrixDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        //Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            Console.Write($"{matrix[i, j], 5}");
        }
       //Console.WriteLine("  |");
       Console.WriteLine();
    }
}

int[,] array2d = CreateMatrixRndDouble(8, 5, -100, 100);
PrintMatrixDouble(array2d);