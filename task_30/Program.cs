// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// int[] array = new int[8]; // 0 1 2 3 4 5 6 7

// int[] array1 = new int[8] { 5, 7, 8, 5, 23, 87, -5, 4 };
// int[] array2 = new int[] { 5, 7, 8, 5, 23, 87, -5, 4 };
// int[] array3 = { 5, 7, 8, 5, 23, 87, -5, 4 };

// var array4 = new int[8];

// array[6] = 6456;
// array[2] = 34;


void FillArr(int[] mass)
{
    int i = 0;
    var random = new Random();
    while(i < mass.Length)
    {
        mass[i] = random.Next(2);
        i++;
    }
}

void PrintArr(int[] mass)
{
    int i = 0;
    while(i < mass.Length)
    {
        Console.Write($"{mass[i]} ");
        i++;
    }
}

int[] array = new int[8];
FillArr(array);
PrintArr(array);