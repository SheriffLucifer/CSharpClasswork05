
int[] array = GetRandomArray(123, -100, 123);
int numberElements = FindNumberElements(array);
Console.WriteLine($"[{String.Join(", ", array)}] -> {numberElements}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int FindNumberElements(int[] array)
{
    int numbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] >= 10) && (array[i] <= 99)) numbers++;
    }
    return numbers;
}