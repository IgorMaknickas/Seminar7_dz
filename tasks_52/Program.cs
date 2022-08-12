// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] GetArray(int m, int n, int min, int max)
{
  int[,] result = new int[m, n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      result[i, j] = new Random().Next(min, max);
    }
  }
  return result;
}

void PrintArray(int[,] inArray)
{
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      Console.Write($"{inArray[i, j]} ");
    }
    Console.WriteLine();
  }
}

int[,] array = GetArray(3, 4, 0, 10);
PrintArray(array);

void srAr(int[,] InArray)
{
   for (int i=0;i<4;i++)
            {
                double summ = 0;
                for (int j=0;j<3;j++)
                {
                    summ = summ + array[j,i];
                }
                double average = summ / 3;
                int n = i + 1;
                Console.WriteLine("Колонка: " +n+", среднее арифмитическое " + average);
            } 
}
srAr(array);