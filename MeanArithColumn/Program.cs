// Задать двумерный массив из целых чисел.
//Найти среднее арифметическое каждого столбца.
//напр  1 4 7 2
//      5 9 2 3
//      8 4 2 4
//сред.ариф. каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Write($"Введите кол-во строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите кол-во столбцов ");
int n = Convert.ToInt32(Console.ReadLine());

void FillArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
    for (int j = 0; j < arr.GetLength(1); j++)
      arr[i, j] = new Random().Next(0, 10);
}

void PrintArray(int[,] ar)
{
  for (int i = 0; i < ar.GetLength(0); i++)
  {
    for (int j = 0; j < ar.GetLength(1); j++)
      Console.Write($"{ar[i, j],2}\t");
    Console.WriteLine();
  }
}

void ArithMeanCol(int[,] array)
{
  for (int j = 0; j < array.GetLength(1); j++)
  {
    double armeancol = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
      armeancol = armeancol + array[i, j];
      if (i == array.GetLength(0) - 1)
      {
        armeancol = Math.Round(armeancol / (i + 1),1);
        Console.Write($"{armeancol}; ");
        break;
      }
    }
  }
}

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
ArithMeanCol(array);
