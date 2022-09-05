/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/

Console.WriteLine("Умножение двух матриц возможно только в том случае, если число столбцов в первой матрице равно числу строк во второй");
Console.Write("Введите количество строк первого массива: ");
int m1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов первого массива: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк второго массива: ");
int m2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов второго массива: ");
int n2 = int.Parse(Console.ReadLine());

int[,] GetArray(int row, int col)
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
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

void ResultArray(int[,] array1, int[,] array2)
{
    int m1 = array1.GetLength(0);
    int n1 = array1.GetLength(1);
    int m2 = array2.GetLength(0);
    int n2 = array2.GetLength(1);
    int[,] result = new int[m1, n2];
    if (n1 != m2)
        Console.WriteLine($"Умножение двух матриц невозможно, так как число столбцов первой матрицы не равно числу строк второй матрицы!");
    else
    {
        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < n2; j++)
            {
                for (int k = 0; k < m2; k++) 
                {
                    result[i, j] += array1[i, k] * array2[k, j];
                }
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

int[,] arr1 = GetArray(m1, n1);
PrintArray(arr1);
Console.WriteLine();
int[,] arr2 = GetArray(m2, n2);
PrintArray(arr2);
Console.WriteLine();
ResultArray(arr1, arr2);

