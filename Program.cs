string[] FillMas(int items)
{
    string[] arr = new string[items];
    for (int i = 0; i < items; i++)
    {
        Console.Write($"Введите {i+1}й элемент: ");
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
Console.Write("Введите количество элементов: ");
int el = int.Parse(Console.ReadLine());
string[] collection = FillMas(el);
PrintMas(collection);