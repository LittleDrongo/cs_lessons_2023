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


int[,] matrixOne = CreateMatrixRndInt(3, 2, 0, 10);
PrintMatrix(matrixOne);
Console.WriteLine();

int[,] matrixTwo = CreateMatrixRndInt(2, 3, 0, 10);
PrintMatrix(matrixTwo);

// void 
int[,] CreateMultiplicationMatrix(int[,] matrixLeft, int[,] matrixRight)
{
    int rowLeftMatrix = matrixLeft.GetLength(0);
    int columnLeftMatrix = matrixLeft.GetLength(1);

    int rowRightMatrix = matrixRight.GetLength(0);
    int columnRightMatrix = matrixRight.GetLength(1);

    int multiRows = rowLeftMatrix < rowRightMatrix ? rowLeftMatrix : rowRightMatrix;
    int multiColumns = columnLeftMatrix < columnRightMatrix ? columnLeftMatrix : columnRightMatrix;

    int[,] matrixMult = new int[multiRows, multiColumns];

    

    return matrixMult;
}

/*
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

int[,] testArray2D = CreateMultiplicationMatrix(matrixOne, matrixTwo);

Console.WriteLine();

PrintMatrix(testArray2D);

Console.WriteLine();
Console.WriteLine();
