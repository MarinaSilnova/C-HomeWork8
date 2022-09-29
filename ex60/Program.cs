// .Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Write("Введите кол-во n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во l: ");
int l = Convert.ToInt32(Console.ReadLine());
int[,,] matrix1 = new int[n, m, l];
{
for (int i = 0; i < n; i++)
{
for (int j = 0; j < m; j++)
{
    for (int z = 0; z < l; z++)
    {
    matrix1[i, j, z] = new Random().Next(1, 100);
}
}
}
    for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
    for (int z = 0; z < l; z++)
    {
    Console.Write( matrix1[i, j, z] + "(" + i + "," + j + "," + z + ")" );
}
 Console.WriteLine();
}
 Console.WriteLine();
}
Console.WriteLine();

}

