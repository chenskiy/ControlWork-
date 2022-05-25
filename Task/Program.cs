void PrintArray(string[] arr)                        // Метод для вывода на печать массива
{
    Console.Write($"[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"]");
}

string[] LimitedCharacters(string[] array)           // Метод для решения задачи
{
    int symbolLength = 3;
    int count = 0;
    for (int i = 0; i < array.Length; i++)           // Считаем количество подходящих элементов            
    {
        if (array[i].Length <= symbolLength)
        {
            count++;
        }
    }

    string[] newArray = new string[count];          // Создаем новый массив для заполнения подходящими элементами 
    int j = 0;

    for (int i = 0; i < array.Length; i++)          // Заполняем массив подходящими элементами
    {
        if (array[i].Length <= symbolLength)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

string[] arrayInput = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer scince", "Rus", "Denmark", "Kazan" };
Console.WriteLine($"Начальный массив:");
PrintArray(arrayInput);
string[] formedArray = LimitedCharacters(arrayInput);
Console.WriteLine();
Console.WriteLine($"Сформированный массив:");
PrintArray(formedArray);