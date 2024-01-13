// Задача 39
// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Console.Clear();

int[] array = GetArray(10, 0, 10); // массив из 10 целых чисел, заполненный от 0 до 10
Console.WriteLine(String.Join(" ", array));

int[] reversArray = ReversArray1(array);
Console.WriteLine(String.Join(" ", reversArray));

ReversArray2(array); // вторая версия решения задачи
// метод ReversArray2, просто получает в качестве параметра массив иходных данных array,
// и никому ничего не возвращает
// метод ReversArray2 изменяет содержимое массива array
Console.WriteLine(String.Join(" ", array));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

// Используем метод ReversArray1 в том случае когда нам нужно получить результат 
// и при этом исходный массив должен остаться не изменным, в которм создаем новый массив 
// и там делаем нужные изменения без потери исходных данных
int[] ReversArray1(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i]; 
        // "inArray.Length - 1" дает нам индекс самого последнего элемента, 
        // а "-i" мы смещаемся вправо на iэлементов 
    }
    return result;
}


// этот метод лучше использовать, когда мало оперативной памяти
// когда нужно использовать большие массивы 
// и тогда когда не нужны данные исходного массива, тогда когда мы мы можем его испортить

void ReversArray2(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int k = inArray[i]; // элемент по индексу i копируем в переменную k
        inArray[i] = inArray[inArray.Length - i - 1]; 
        // берем элемент с правого конца "inArray.Length - i - 1" копируем 
        // в наш массив "inArray[i]", только в начало, поэту то значение, 
        // кторое было по индексу i сотрётся новым значением, 
        // и для того чтобы оно не потерялось, 
        // мы его сохранили во временную переменную k в 55-й строке 
        inArray[inArray.Length - i - 1] = k; 
        // скопированное значение k, записывает его значение 
        // в конец "inArray[inArray.Length - i - 1]"
    }
}