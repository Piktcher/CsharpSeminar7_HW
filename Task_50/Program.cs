// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// // 17 -> такого числа в массиве нет

int rows = 3;
int columns = 4;
int[,] matrix = new int[rows,columns];

int[,] CreateArray (int rows, int columns)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1, 100);
        }
    }

    return matrix;
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] result = CreateArray(rows, columns);
PrintArray(result);

Console.WriteLine("Укажите строку для поиска элемента");
int indexRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите столбец для поиска элемента");
int indexColumn = Convert.ToInt32(Console.ReadLine());

if (indexRow < result.GetLength(0) && indexColumn < result.GetLength(1)) Console.WriteLine(result[indexRow, indexColumn]);
else Console.WriteLine("Такого элемента нет в массиве");