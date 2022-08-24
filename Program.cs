string[] FillMas(int items)
{
    string[] arr = new string[items];
    for (int i = 0; i < items; i++)
    {
        Console.Write($"Введите {i + 1}й элемент: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintMas(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

string[] ChangeMas(string[] massive)
{
    int count = 0;
    int len = 0;
    for (int j = 0; j < massive.Length; j++)
    {
        foreach (char k1 in massive[j])
        {
            count++;
        }
        if (count <= 3) { len++; }
        count = 0;
    }

    string[] mas1 = new string[len];
    count = 0;
    int position = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        foreach (char k2 in massive[i])
        {
            count++;
        }
        if (count <= 3)
        {
            mas1[position] = massive[i];
            position++;
        }
        count = 0;
    }
    return mas1;
}

Console.Write("Введите количество элементов: ");
int el = int.Parse(Console.ReadLine());
string[] collection = FillMas(el);
PrintMas(collection);
string[] shortlist = ChangeMas(collection);
PrintMas(shortlist);