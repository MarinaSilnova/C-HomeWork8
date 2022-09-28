// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Clear();

void InputMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
matrix[i, j] = new Random().Next(1, 10);
}
}


void PrintMatrix(int[,] matrix)
{
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
Console.Write(matrix[i, j] + " \t");
Console.WriteLine();
}
}


 int[,] ReleaseMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
     for (int j = 0; j < matrix.GetLength(1); j++)
    { 
        for (int a = j + 1; a < matrix.GetLength(1); a++)
    { 
            if (matrix[i, j] < matrix[i, a])
            {
            int max = matrix[i, j];
            matrix[i, j] = matrix[i, a];
            matrix[i, a] = max;
            }
        }
        }
    }
    return matrix;
    }  


Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
PrintMatrix(ReleaseMatrix(matrix));;
