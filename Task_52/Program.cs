// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int rows = 3;
int columns = 4;
int[,] matrix = new int[rows, columns];

int[,] CreateArray(int rows, int columns)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
        }
    }

    return matrix;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] result = CreateArray(rows, columns);
PrintArray(result);

void CalcColumnAverage(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double count = 0;
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            count++;
        }
        double average = Math.Round(sum / count, 2);
        Console.WriteLine($"Среднее арифметическое столбца {j + 1} равно {average}");
    }
}

CalcColumnAverage(result);