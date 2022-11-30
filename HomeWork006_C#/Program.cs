// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

/*
Console.WriteLine("Введити количество чисел в массиве: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = FillArray(size);

Console.WriteLine($"Получившийся массив: [{String.Join(", ", array)}]");
Console.WriteLine($"Количество чисел, больших нуля : {FindNum(array)}");

///////////////////// Method  ////////////////////////

int[] FillArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(-10, 10);
    }
    return res;
}

///////////////////// Method  ////////////////////////

int FindNum(int[] ar)
{
    int count = 0;
    for (int i = 0; i < ar.Length; i++)
        if (ar[i] > 0)
        {
            count++;
        }
    return count;
}
*/

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100,
// а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).

int[] array = GetArray(8, 0, 100);
Console.WriteLine($"Исходный массив: [{String.Join(", ", array)}]");
SortArray(array);
Console.WriteLine();
Console.WriteLine($"Конечный массив: [{String.Join(", ", array)}]");

///////////////////// Method  //////////////////////// 

int[] GetArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

///////////////////// Method  //////////////////////// 

void SortArray(int[] ar)
{
    for (int i = 0; i < ar.Length - 1; i++)
    {
        int min = i;
        for (int j = i + 1; j < ar.Length; j++)
        {
            if (ar[j] < ar[min])
            {
                min = j;
            }
        }
        int temp = ar[i];
        ar[i] = ar[min];
        ar[min] = temp;
    }

}