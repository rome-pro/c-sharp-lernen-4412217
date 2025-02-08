
void BubbleSort(int[] toSort)
{
  for (int i = 0; i < toSort.Length; i++)
  {
    for (int j = i + 1; j < toSort.Length; j++)
    {
      if (toSort[i]> toSort[j])
      {
        int temp = toSort[j];
        toSort[j] = toSort[i];
        toSort[i] = temp;
        Console.WriteLine("Nächste Iteration: ");
        for (int x = 0; x < toSort.Length; x++)
        {
          Console.WriteLine(toSort[x]);
        }
      }
    }
  }
}


int[] mein_erstes_array = { 22, 1, 21, 11, 5, 3 };

Console.WriteLine(mein_erstes_array);

BubbleSort(mein_erstes_array);