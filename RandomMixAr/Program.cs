// Массив случайных целых чисел m*n, чётное кол-во элементов.
//Перемешать случайным образом элементы массива, каждый элемент переместится только 1 раз!
//Кол-во перемещений m*n/2 с выводом на экран
//напр: вход 2 3 5 1mix '4 3 5 2mix 4'5'3 3mix 4 5 3
//           1 9 4      1 9'2      1 9 2       '9'1 2 
Console.Write($"Введите кол-во строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите кол-во столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
int repeat = m * n / 2;                         //кол-во перемещений

void FillArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
    for (int j = 0; j < arr.GetLength(1); j++)
      arr[i, j] = new Random().Next(0, 10);
}

void FillArr(bool[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
    for (int j = 0; j < arr.GetLength(1); j++)
      arr[i, j] = true;
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

void PrintArr(bool[,] ar)
{
  for (int i = 0; i < ar.GetLength(0); i++)
  {
    for (int j = 0; j < ar.GetLength(1); j++)
      Console.Write($"{ar[i, j],2}\t");
    Console.WriteLine();
  }
}

bool[,] mix = new bool[m, n];
FillArr(mix);

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int count = 1;
while (count <= repeat)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int k = new Random().Next(0, m);
    for (int j = 0; j < array.GetLength(1); j++)
    {
      int g = new Random().Next(0, n);
      if ((k != i && g != j) && (mix[i, j] == true && mix[k, g] == true))
      {
        Console.Write($"индекс i, j ");
        Console.Write($"{i}, {j}");
        Console.WriteLine();

        mix[i, j] = false;
        mix[k, g] = false;
        int temp = array[i, j];
        array[i, j] = array[k, g];
        array[k, g] = temp;

        Console.Write($"меняем на k, g ");
        Console.Write($"{k}, {g}");
        Console.WriteLine();
        Console.WriteLine($"count={count}");
        PrintArray(array);
        PrintArr(mix);
        count++;
      }
    }
  }
}
