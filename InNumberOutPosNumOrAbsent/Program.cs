// На вход значение элемента в двумерном массиве, 
//на выход позиция этого элемента или сообщение что отсутствует
Console.Write($"Введите кол-во строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите кол-во столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число ");
int a = Convert.ToInt32(Console.ReadLine());

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

bool PosOrAbsent(int[,] array)
{
  bool res = false;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (a == array[i, j])
      {
        Console.WriteLine($"число {a} на строке {i + 1} в столбце {j + 1}");
        res = true;
        break;
      }
    }
    if (res==true) break;
  }
  return res;
}

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
bool res = PosOrAbsent(array);
if (res == false)
  Console.WriteLine($"число {a} отсутствует в массиве");
