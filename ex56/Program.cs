// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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


int ReleaseMatrix(int[,] matrix)
{
Console.WriteLine();
int sum1 = int.MaxValue; 
int sum2 = 0;
int row = 0;
for(int i = 0; i < matrix.GetLength(0); i++) 
 {
        sum2 = 0;
        for(int j = 0; j < matrix.GetLength(1); j++) 
        {   
         sum2 += matrix[i, j];  
        }
                if (sum2 < sum1)
                {
                row = i;   
                }
        sum1 = sum2;
}
 return row;
}

 
 






Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine(ReleaseMatrix(matrix));

