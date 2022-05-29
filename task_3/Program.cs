void FindArray(int[,] arr)
{
    double sum = 0.0;
    int j = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (j != arr.GetLength(1))
        {
            sum += arr[i, j];
            if (i + 1 == arr.GetLength(0))
            {
                sum = sum / arr.GetLength(0);
                Console.WriteLine($"Среднее арифметическое элементов в {j+1} столбце = {sum}");
                i = -1; j++; sum = 0.0;
            }
        }
    }
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
Console.WriteLine();
FindArray(arr);