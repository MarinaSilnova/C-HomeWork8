//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[n, m];
{
for (int i = 0; i < matrix1.GetLength(0); i++)
{
for (int j = 0; j < matrix1.GetLength(1); j++)
{
    matrix1[i, j] = new Random().Next(1, 10);
}
}
    for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
    Console.Write($"{matrix1[i, j]} ");
    }
    Console.WriteLine();

}
}

int[,] matrix2 = new int[n, m];
{
Console.WriteLine();
for (int i = 0; i < matrix2.GetLength(0); i++)
{
for (int j = 0; j < matrix2.GetLength(1); j++)
{
    matrix2[i, j] = new Random().Next(1, 10);
}
}
for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
     Console.Write($"{matrix2[i, j]} ");
    }
    Console.WriteLine();
}
}

int[,] matrix3 = new int[n, m];
{
Console.WriteLine();
for (int i = 0; i < matrix3.GetLength(0); i++)
{
for (int j = 0; j < matrix3.GetLength(1); j++)
{
    matrix3[i, j] = matrix1[i, j] * matrix2[i, j];
}
}
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
    for (int j = 0; j < matrix3.GetLength(1); j++)
    {
   Console.Write($"{matrix3[i, j]} ");
    }
    Console.WriteLine();
}
}






