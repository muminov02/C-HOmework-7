string FindArray(int[,] arr)
{
    Console.Write("Введите позицию в строке: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Введите позицию в столбце: ");
    int b = int.Parse(Console.ReadLine());
    a--; b--;
    if (a >= arr.GetLength(0) || b >= arr.GetLength(1))
        return $"There is no value at {a+1} and {b+1}";
        
    return $"{arr[a, b]}";
}


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}    ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int[,] arr, int from, int to)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}


Console.Write("Введите количество строк: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int b = int.Parse(Console.ReadLine());
int[,] arr = new int[a, b];


FillArray(arr, 0, 10);
PrintArray(arr);
Console.WriteLine(FindArray(arr));