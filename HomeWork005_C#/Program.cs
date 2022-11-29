// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
int[] arr = FillArray(10, 100, 1000);
Console.WriteLine($"[{String.Join(", ", arr)}]");

int count = 0;
foreach (int el in arr)
{
    if (el % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество чётных чисел в массиве равно {count}");

////////////// method //////////////////

int[] FillArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}
*/







/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(индексы элементов должны быть нечетными(1,3,5 и тд)).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
int[] arr = new int[4];
Console.WriteLine($"[{String.Join(", ", GetArray(arr))}]");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {GetSum(arr)}");

////////////// method //////////////////
int[] GetArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

////////////// method //////////////////
int GetSum(int [] ar)
{
    int sum = 0;
    for (int i = 0; i < ar.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + ar[i];
        }
    }
    return sum;
}
*/





/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

/*
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = new int[size];
Console.WriteLine($"Заданный массив: [{String.Join(", ", FillArr(array))}]");
Console.WriteLine($"Результат произведения пар чисел в массиве: [{String.Join(", ", ResArr(array))}]");

////////////// method //////////////////
int[] FillArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 21);
    }
    return arr;
}

////////////// method //////////////////

int[] ResArr(int[] ar)
{
    int i = 0;
    int j = 0;
    int k = ar.Length - 1;
    int size = ar.Length;
    if (ar.Length % 2 == 0)
    {
        size = ar.Length / 2;
    }
    else
    {
        size = (ar.Length / 2) + 1;
    }

    int[] resAr = new int[size];
    while (i < k)
    {
        resAr[j] = ar[i] * ar[k];
        i++;
        j++;
        k--;

    }
    if (ar.Length % 2 > 0)
    {
        resAr[j] = ar[ar.Length / 2];
    }
    
    return resAr;
}
*/


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 38: Задайте массив целых чисел от -10 до 10. Найдите разницу между максимальным и минимальным элементов массива.

/*
int[] arr = new int[10];
Console.WriteLine($"[{String.Join(", ", FillArr(arr))}]");
Console.WriteLine($"Минимальный элемент массива {MinEl(arr)}, максимальный элемент массива {MaxEl(arr)}");
int dif = MaxEl(arr) - MinEl(arr);
Console.WriteLine($"Разница, между максимальным и минимальным элементами массива равна {dif}");

////////////// method //////////////////

int[] FillArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 11);
    }
    return arr;
}

////////////// method //////////////////

int MinEl(int[] array)
{
    int min = arr[0];
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i] < min)
        {
            min = array[i];
        }
        
    }return min;

}

////////////// method //////////////////

int MaxEl(int[] array)
{
    int max = arr[0];
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i] > max)
        {
            max = array[i];
        }
        
    }return max;

}
*/
