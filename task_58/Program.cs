/*
    Задача 58: Задайте две матрицы. 
    Напишите программу, которая будет находить произведение двух матриц.
    Например, даны 2 матрицы:
    2 4 | 3 4
    3 2 | 3 3
    Результирующая матрица будет:
    18 20
    15 18
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

void PrintMatrix(int[,] matrix)
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


int[,] CreateMultiplicationMatrix(int[,] matrixLeft, int[,] matrixRight)
{
    int rowsLeftMatrix = matrixLeft.GetLength(0);
    int columnsLeftMatrix = matrixLeft.GetLength(1);

    int rowsRightMatrix = matrixRight.GetLength(0);
    int columnsRightMatrix = matrixRight.GetLength(1);

    int multiRows = rowsLeftMatrix < rowsRightMatrix ? rowsLeftMatrix : rowsRightMatrix;
    int multiColumns = columnsLeftMatrix < columnsRightMatrix ? columnsLeftMatrix : columnsRightMatrix;

    int[,] matrixMult = new int[multiRows, multiColumns];


    for (int i = 0; i < multiRows; i++)
    {
        for (int j = 0; j < multiRows; j++)
        {
            matrixMult[i, j] = 0;
            for (int k = 0; k < multiRows; k++)
            {
                matrixMult[i, j] += matrixLeft[i, k] * matrixRight[k, j];
            }
        }
    }
    return matrixMult;
}

/*  ЗАМЕТКА
    Проверяем, что число столбцов матрицы A равно числу строк матрицы B. 
    Далее берем первую строчку левой матрицы и умножаем её на первый столбец второй матрицы.

    Теперь умножаем первую строку левой матрицы на второй столбец правой матрицы. 
    Далее вторую строчку левой матрицы и умножаем на первый столбец второй матрицы. 
    И осталось умножить первую строку левой матрицы на второй столбец правой матрицы.

     2 1     1 -3     4 -6
    -3 4     2  0     5  9

    2*1 + 1*2    =   4
    2⋅(−3)+1⋅0    =  -6
    (−3)⋅1+4⋅2    =   5
    (−3)⋅(−3)+4⋅0 =   9
    ​
    int test = (2*-3+1*0);
    Console.WriteLine ($"ETO TEST{test}");
    
    https://xn--24-6kcaa2awqnc8dd.xn--p1ai/proizvedenie-matric.html
*/

int[,] matrixOne = CreateMatrixRndInt(2, 2, 1, 4);
PrintMatrix(matrixOne);
Console.WriteLine();


int[,] matrixTwo = CreateMatrixRndInt(2, 2, 1, 4);
PrintMatrix(matrixTwo);
Console.WriteLine();

int[,] testArray2D = CreateMultiplicationMatrix(matrixOne, matrixTwo);

Console.WriteLine();

PrintMatrix(testArray2D);