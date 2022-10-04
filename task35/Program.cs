int[] GetArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int NumberElementsInArray(int[] array)       //количество элементов в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            count = count + 1;
        }
    }
    return count;
}

int[] array = GetArray(123, 0, 150);
Console.WriteLine(string.Join(", ", array));
int res = NumberElementsInArray(array);
Console.WriteLine($"Количество элементов в промежутке от 10 до 99 составляет {res}: ");