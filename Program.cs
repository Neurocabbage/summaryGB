// Написать программу, которая из имеющегося массива строк формирует массив
// из строк, длина которых меньше либо равна 3 символа. 

using System;
using static System.Console;

Clear();

string[] arr; // массив строк
int n; // количество элементов в массиве

string[] array3char;

// Ввод количества строк
Write("Введите количество элементов: ");
n = int.Parse(ReadLine());

arr = new string[n];
array3char = new string[n];

WriteLine("Введите массив: ");

for (int i=0; i<arr.Length; i++)
{
    Write($"arr[{i}] = ");
    arr[i] = ReadLine();
}

void ArrayLess3char(string[] array1, string[] array2)
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[j] = array1[i];
        j++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}

ArrayLess3char(arr, array3char);
PrintArray(arr);
WriteLine();
PrintArray(array3char);