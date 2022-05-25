string[] LimitedCharacters(string[] array)
{
    int symbolLength = 3;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= symbolLength)
        {
            count++;
        }
    }

    string[] newArray = new string[count];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= symbolLength)
        {
            newArray[j] = array[i];
            Console.Write($"{newArray[j]} ");
            j++;
        }
    }
    return newArray;
}

string[] arrayInput = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer scince", "Russia", "Denmark", "Kazan" };
LimitedCharacters(arrayInput);