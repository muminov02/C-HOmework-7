using System;

void PrintArray(double[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}    ");
        }
        Console.WriteLine();
    }
}

double[,] FillArray(double from, double to){
    Console.Write("Введите количество строк: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int b = int.Parse(Console.ReadLine());
    double[,] arr = new double[a,b];
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = Math.Round(random.NextDouble() * (to - from) + from,1);
        }
    }
    return arr;
}

PrintArray(FillArray(-20.0,20.0));