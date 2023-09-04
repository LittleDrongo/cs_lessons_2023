// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник со сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

bool ExistenceOfTriangle(int firstSide, int secondSide, int thirdSide)
{
    if (firstSide + secondSide > thirdSide
        && firstSide + thirdSide > secondSide
        && secondSide + thirdSide > firstSide)
        return true;
    else return false;
}

Console.Write("Введите первую сторону: ");
int side1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую сторону: ");
int side2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью сторону: ");
int side3 = Convert.ToInt32(Console.ReadLine());
bool result = ExistenceOfTriangle(side1, side2, side3);
Console.WriteLine(result ? "существует" : "несуществует");