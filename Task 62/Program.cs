/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. */
Console.Write("Введите количество строк (столбцов) квадратного двумерного массива: ");
int row = int.Parse(Console.ReadLine());

int[,] SpiralArray(int row)
{
    int[,] result = new int[row, row];
    int count = 1;
    int x = row - 1;
    int y = 0;
    while (count <= row * row)
    {
        for (int j = y; j < x + 1; j++)
        {
            result[y, j] = count;
            count++;
        }
        for (int i = y + 1; i < x + 1; i++)
        {
            result[i, x] = count;
            count++;
        }
        for (int j = x - 1; j >= y; j--)
        {
            result[x, j] = count;
            count += 1;
        }
        for (int i = x - 1; i >= y + 1; i--)
        {
            result[i, y] = count;
            count++;
        }
        x -= 1;
        y += 1;
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],4}");
        }
        Console.WriteLine();
    }
}
 int[,] arr = SpiralArray(row);
 Console.WriteLine("Заполнить массив спирально 4*4: ");
 PrintArray(arr);
