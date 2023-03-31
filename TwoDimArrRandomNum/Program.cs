// Задать двумерный массив размером mxn, заполненный случайными вещественными числами
//например m=3, n=4 0,5  7  -2  -0,2
//                  1  -3,3  8  -9,9
//                  8  7,8  -7,1  9
Console.Write($"Введите кол-во строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите кол-во столбцов ");
int n = Convert.ToInt32(Console.ReadLine());

void FillArray(double[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
    for (int j = 0; j < arr.GetLength(1); j++)
      arr[i, j] = Math.Round(-10 + new Random().NextDouble()*(7.9+10),1);

}

void PrintArray(double[,] ar)
{
  for (int i = 0; i < ar.GetLength(0); i++)
  {
    for (int j = 0; j < ar.GetLength(1); j++)
      Console.Write($"{ar[i, j],4}\t");
    Console.WriteLine();
  }
}


double[,] Array = new double[m, n];
FillArray(Array);
PrintArray(Array);
