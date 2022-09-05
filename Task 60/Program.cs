/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2*/
Console.WriteLine("Введите x - первую размерность массива");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y - вторую размерность массива");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите z - третью размерность массива");
int z = int.Parse(Console.ReadLine());

 int[,,] GetArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
        {
             for (int k = 0; k < array.GetLength(2); k++)
            {
                 array[i, j, k] = new Random().Next(10, 100);

            }
        }
    }
    return array;
}

bool CheckNumbers (int[,,] array, int row, int column, int deepness)
{
    bool result = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i,j,k] == array[row, column, deepness] 
                && i != row
                && j != column
                && k != deepness) return true;
            }
        }
    }
    return result;
}

 void PrintArray(int[,,] array)
 {
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             for (int k = 0; k < array.GetLength(2); k++)
             {
                 Console.Write($"{array[i, j, k]} ({i},{j},{k})\t");
             }
             Console.WriteLine();
         }
     }
 }

 int[,,] arr = GetArray(x, y, z);
 Console.WriteLine("Сформируй трехмерный массив: ");
 PrintArray(arr);

