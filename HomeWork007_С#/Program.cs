// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] array = new double [3, 4];
// GetArray(array);
// PrintArray(array);

// void  GetArray(double[,] array)
// {
//     for (int i = 0; i <array.GetLength(0) ; i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100))/10;
//         }
//     }
// }


// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]:f1}  ");
//         }
//         Console.WriteLine();
//     }
// }


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 5; j = 2 -> такого числа в массиве нет
// i = 1; j = 1 -> 9

// int[,] array = new int[5, 5];
// Console.WriteLine("Введите позицию строки: ");
// int row = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите позицию столбца: ");
// int column = int.Parse(Console.ReadLine()!);

// FillArray(array);
// PrintArray(array);

// if(row > array.GetLength(0) || column > array.GetLength(1))
// {
//     Console.WriteLine("Такого числа в массиве нет! ");
// }
// else
// {
//     Console.WriteLine($"Значение элемента на строке {row} и в столбце {column} равно {array [row-1, column-1]} ");
// }



// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray (int[,] array)
// {
//     for (int i =0; i<array.GetLength(0); i++)
//     {
//         for(int j = 0; j<array.GetLength(1); j++)
//         {
// Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Average(array);


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Average(int[,] array)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        double average = sum / array.GetLength(0);
        Console.Write($"{average:f1}  ");

    }
}