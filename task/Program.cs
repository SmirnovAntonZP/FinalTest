Console.Write("Введите количество элементов в массиве: ");
int N = int.Parse(Console.ReadLine() ?? "0");

int count = 0;

string[] StringArray = GetArray(N);
string[] GetArray(int length)
{
    string[] array = new string[length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}й элемент массива: ");
        array[i] = (Console.ReadLine() ?? "0");
    }
    return array;
}

int newArrayLength = NewArrayLength(StringArray);
int NewArrayLength(string[] TextArray)
{
    count = 0;
    for (int i = 0; i < TextArray.Length; i++)
    {
        if (TextArray[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

if (count > 0)
{
    string[] newArray = NewStringArray(UserArray: StringArray, count: newArrayLength);
    string[] NewStringArray(string[] UserArray, int count)
    {
        int newcount = 0;
        string[] ArrayofShortString = new string[count];
        for (int i = 0; i < UserArray.Length; i++)
        {
            if (UserArray[i].Length <= 3)
            {
                ArrayofShortString[newcount] = UserArray[i];
                newcount++;
            }

        }
        return ArrayofShortString;
    }

    void PrintArray(string[] TextArray)
    {
        foreach (var item in TextArray)
        {
            Console.Write(item + " ");
        }
    }


    Console.Write("Массив заданный пользователем: ");
    PrintArray(StringArray);
    Console.WriteLine();
    Console.Write("Новый массив строк длинной не более 3-х элементов: ");
    PrintArray(newArray);
    Console.WriteLine();
}
else Console.Write("Массив заданный пользователем не содержит строк состоящих из 3-х или менее элементов");
Console.WriteLine();
