// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Результатом возведения числа {A} в степень {B} будет {GetRes(A, B)}");

//////////  метод   ////////

int GetRes(int num1, int num2)
{
    int result = 1;
    for (int i = 0; i < num2; i++)
    {
        result = result * num1;
    }
    return result;
}
*/





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр числа {num} будет равна {GetSum(num)}");

//////////  метод   ////////

int GetSum(int numb)
{
    int result = 0;
    while (numb > 0)
    {
        result = result + numb % 10;
        numb = numb / 10;
    }
    return result;

}
*/





//   Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

int[] array = new int [8];
PrintArr(array);
Console.WriteLine($"Массив:  [{String.Join("  ", array)}]");

//////////  метод   //////// 

int[] PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}
