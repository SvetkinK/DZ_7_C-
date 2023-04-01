// Задать двумерный массив из целых чисел. Задать кол-во строк и столбцов
//Отсортировать элементы по возрастанию слева направо и сверху вниз
//напр: вход 1 4 7 2  выход 1 2 3 4
//           5 9 10 3       5 7 9 10
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
      Console.Write($"{ar[i, j],2}");
    Console.WriteLine();
  }
}

void SelectionSort(int[] array)
{
  for (int i = 0; i < array.Length; i++)                         //(int i = 0; i < array.Length - 1; i++)
  {
    int minPosition = i;
    for (int j = i + 1; j < array.Length; j++)                              //ищем минимальный элемент в неотсортированной части
    {
      if (array[j] < array[minPosition]) minPosition = j;
    }

    int temporary = array[i];                              //после выполнения действий выше надо поменять вначале заданную i на ту, кот.нашли temporary
    array[i] = array[minPosition];
    array[minPosition] = temporary;
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

int[] one = new int[m * n];                           //перевод из двумерного массива в одномерный
int count = 0;
for (int i = 0; i < array.GetLength(0); i++)
  for (int j = 0; j < array.GetLength(1); j++)
  {
    one[count] = array[i, j];
    Console.Write($"{one[count]} ");
    count++;
  }
Console.WriteLine();

SelectionSort(one);

count = 0;                                            //возврат из одномерного массива в двумерный
for (int i = 0; i < array.GetLength(0); i++)
  for (int j = 0; j < array.GetLength(1); j++)
  {
    array[i, j] = one[count];
    count++;
  }

PrintArray(array);
