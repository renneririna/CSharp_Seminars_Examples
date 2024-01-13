// Задача 53
// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.Clear();

int[,] array = GetArray(5, 10);
PrintArray(array);
ChangeRows(array);
Console.WriteLine();
PrintArray(array);

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
            Console.Write($"{inArray[i, j]}\t"); // "\t" - символ табуляции
        }
        Console.WriteLine();
    }
}

void ChangeRows(int[,] array)
{
    int m = array.GetLength(0);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[0, j];
            array[0, j] = array[m - 1, j];
            array[m - 1, j] = temp;
        }
}