int[] numbers = { 3, 8, 1, 2, 9, 3, 6, 2, 7 };

void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]}");
  }
  Console.WriteLine($"");
}

void SelectionSort(int[] array)
{
  for (int i = 0; i < array.Length - 1; i++)
  {
    for (int j = i + 1; j < array.Length; j++)
    {
      if (array[i] > array[j])
      {
        int a = array[i];
        array[i] = array[j];
        array[j] = a;
      }
      else continue;
    }
  }

}


PrintArray(numbers);
SelectionSort(numbers);
PrintArray(numbers);