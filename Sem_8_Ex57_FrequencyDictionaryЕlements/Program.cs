// Задача 57
// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Набор данных  { 1, 9, 9, 0, 2, 8, 0, 9 }
// Частотный массив 0 встречается 2 раза 
//                  1 встречается 1 раз 
//                  2 встречается 1 раз 
//                  8 встречается 1 раз 
//                  9 встречается 3 раза

Console.Clear();

int[,] array = GetArray(1, 10);
PrintArray(array);
Console.WriteLine();
int[,] frequencyArray = FrequencyArray(array);
PrintArray(frequencyArray);

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(-10, 11);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

bool IsContains(int[] array, int n)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == n)
        {
            return true;
        }
    }
    return false;
}

int[] GetUniqArray(int[,] array)
{
    int count = 0;
    int[] uniqTempArray = new int[array.GetLength(0) * array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (!IsContains(uniqTempArray, array[i, j]))
            {
                uniqTempArray[count] = array[i, j];
                count++;
            }
        }
    }
    int[] uniqArray = new int[count];
    for (int i = 0; i < uniqArray.Length; i++)
    {
        uniqArray[i] = uniqTempArray[i];
    }
    Array.Sort(uniqArray);
    return uniqArray;
}

int[,] FrequencyArray(int[,] array)
{
    int[] uniqArray = GetUniqArray(array);
    int[,] frequency = new int[uniqArray.Length, 2];
    for (int i = 0; i < uniqArray.Length; i++)
    {
        frequency[i, 0] = uniqArray[i];
        frequency[i, 1] = GetCount(array, frequency[i, 0]);
    }
    return frequency;
}

int GetCount(int[,] array, int number)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == number) count++;
        }
    }
    return count;
}