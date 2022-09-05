/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/
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

int[,] DecreasingArray (int[,] array)
{ 
         for (int i = 0; i < array.GetLength(0); i++)
         { 
            for (int j = 0; j < array.GetLength(1); j++)
            {
               for (int d = 0; d < array.GetLength(1) - 1; d++)
               {
                   if (array[i, d] < array[i, d + 1])
                   {
                       int temp = array[i, d + 1];
                       array[i, d + 1] = array[i, d];
                       array[i, d] = temp;
                   }
                }
            }

         }
         return array;
}

int[,] myArray = GetArray(row, col, beginNum, endNum);
Console.WriteLine("Изначально заданный массив: ");
PrintArray(myArray);
Console.WriteLine();
Console.WriteLine("Элементы массива отсортированы по убыванию: ");
int[,] arr = DecreasingArray(myArray);
PrintArray(arr);
