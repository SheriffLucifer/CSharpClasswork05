Console.Clear();
int[] array = GetRandomArray(4, -9, 20);
int[] newArray = CreateNewArray(array);
Console.WriteLine($"[{String.Join(" ", array)}] -> {String.Join(" ", newArray)}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int[] CreateNewArray(int[] array)
{
    int size = 0;
    if (array.Length % 2 == 1)
    {
        size = array.Length / 2 + 1;
    }
    else
    {
        size = array.Length / 2;
    }

    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        if ((array.Length % 2 == 1) && (i == size - 1))
        {
            result[i] = array[i];
        }
        else
        {
            result[i] = array[i] * array[array.Length - i - 1];
        }
    }
    return result;
}