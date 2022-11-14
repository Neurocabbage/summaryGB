// Написать программу, которая из имеющегося массива строк формирует массив
// из строк, длина которых меньше либо равна 3 символа. 

using System;
using static System.Console;

Clear();

string[] arr; // массив строк начальный
int n; // количество элементов в массиве
string[] array3char; // массив строк результирующий

// Ввод количества строк
Write("Введите количество элементов: ");
n = int.Parse(ReadLine());

arr = new string[n];
array3char = new string[n];

// ввод массива
WriteLine("Введите массив: ");

for (int i=0; i<arr.Length; i++)
{
    Write($"arr[{i}] = ");
    arr[i] = ReadLine();
}

// формирование нового массива
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

// вывод массива
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