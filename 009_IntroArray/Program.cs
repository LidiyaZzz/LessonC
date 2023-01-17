void FillArray(int[] collection)
{
  for (int i = 0; i < collection.Length; i++)
  {
    collection[i] = new Random().Next(1, 10);
  }
}

void PrintArray(int[] collection)
{
  for (int i = 0; i < collection.Length; i++)
  {
    Console.WriteLine(collection[i]);
  }
}

int IndexOf(int[] collection, int find)
{
  int position = -1;
  for (int i = 0; i < collection.Length; i++)
  {
    if (collection[i] == find)
    {
      position = i;
      break;
    }
  }
  return position;
}

int[] nembers = new int[10];


FillArray(nembers);
PrintArray(nembers);
Console.WriteLine(" ");

int position = IndexOf(nembers, 4);
Console.WriteLine(position);




