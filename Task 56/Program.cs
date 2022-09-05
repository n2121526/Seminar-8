/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/
Console.Write("Число строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Число столбцов: ");
int col = int.Parse(Console.ReadLine());
Console.Write("Начало диапазона значений: ");
int beginNum = int.Parse(Console.ReadLine());
Console.Write("Окончание диапазона: ");
int endNum = int.Parse(Console.ReadLine());

int[,] GetArray(int row, int col, int beginNum, int endNum)
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(beginNum, endNum + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MinSumRow(int[,] arr)
{
    int[] sum = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum[i] += arr[i, j];
        }
    }
    int min = sum[0];
    int l = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        if (sum[i] <= min)
        {
            min = sum[i];
            l = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов в строке: {l + 1}");
}

int[,] myArray = GetArray(row, col, beginNum, endNum);
PrintArray(myArray);
Console.WriteLine();
MinSumRow(myArray);
