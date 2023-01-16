int[] array = GetRandomArray(12, -9, 9);
int sumPositives = GetSumPositives(array);
int sumNegatives = GetSumNegatives(array);

Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Сумма положительных чисел: {sumPositives}");
Console.WriteLine($"Сумма отрицательных чисел: {sumNegatives}");

int GetSumPositives(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum += array[i];
    }

    return sum;
}

int GetSumNegatives(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sum += array[i];
    }

    return sum;
}

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}