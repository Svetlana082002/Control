string[] arr = new[] { "Hayastan", "Svetik", "muk", "jut" };
int size = arr.Length;
string [] arr2 = new string [size];
int j = 0;
for (int i = 0; i < size; i++)
{
    if (arr[i].Length <= 3)
    {
        arr2[j] = arr[i];
        Console.Write($"{arr2[j]}, ");
        j++;
    }
}
