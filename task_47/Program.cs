// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] GetArray(int m, int n, int min, int max)
{
    Random rn = new Random();
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = min + rn.NextDouble() * (max - min);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,5:f1}",inArray[i, j]));
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

double[,] array = GetArray(rows, columns, -10, 10);

PrintArray(array);

