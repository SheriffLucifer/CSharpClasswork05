int[] array = GetRandomArray(5, -9, 999);
Console.WriteLine($"[{String.Join(", ", array)}]");
int number = GetNumber($"Введите любое целое число: ", "Ошибка ввода!");
bool checkNumber = CheckNumber(number, array);

Console.WriteLine($"{number}; массив [{String.Join(", ", array)}] -> {(checkNumber ? "да" : "нет")}");

int GetNumber(string message, string error)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int number);
        if (isCorrect) return number;
        Console.WriteLine(error);
    }
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

bool CheckNumber(int number, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return true;
        i++;
    }
    return false;
}