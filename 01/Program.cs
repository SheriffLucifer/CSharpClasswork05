int[] array = GetRandomArray(4, -9, 9);
int[] newArray = ChangeArray(array);

Console.WriteLine($"[{String.Join(", ", array)}] -> [{String.Join(", ", newArray)}]");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int[] ChangeArray(int[] array)
{
    int[] sum = new int[array.Length];
    for (int i = 0; i < sum.Length; i++)
    {
        sum[i] = array[i] * -1;
    }
    return sum;
}