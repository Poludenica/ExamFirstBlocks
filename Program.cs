﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Первый вариант с вводом от пользователя:
/*
string[] CreateArray()
{
    Console.Write("Input the array size: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];
    for (int i = 0; i < size; i += 1)
    {
        Console.Write($"Input {i + 1} element of the array: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i += 1)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
string[] ResultArray(string[] array)
{
    int c = 0;
    int j = 0;
    for (int i = 0; i < array.Length; i += 1)
    {
        if (array[i].Length <= 3) c += 1;
    }
    string[] arrayRes = new string[c];
    for (int i = 0; i < array.Length; i += 1)
     {
        if (array[i].Length <= 3)
        {
            arrayRes[j] = array[i];
            j += 1;
        }
    }
    return arrayRes;
}
string[] arrayFirst = CreateArray();
Console.WriteLine();
Console.WriteLine("The created array:");
ShowArray(arrayFirst);
Console.WriteLine();
string[] arraySecond = ResultArray(arrayFirst);
Console.WriteLine("A new array of strings that are less than or equal to 3 characters long:");
ShowArray(arraySecond);
*/

// Второй вариант с уже заданным массивом:
/*
string[] arrayFirst = new string[6] {"123", "23", "hello", "world", "Peace", "computer-science"};
Console.WriteLine("An array is defined: ");
string[] arraySecond = new string[arrayFirst.Length];
void SecondArray(string[] arrayFirst, string[] arraySecond)
{
    int count = 0;
    for (int i = 0; i < arrayFirst.Length; i++)
    {
    if(arrayFirst[i].Length <= 3)
        {
        arraySecond[count] = arrayFirst[i];
        count++;
        }
    }
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

ShowArray(arrayFirst);
Console.WriteLine();
SecondArray(arrayFirst, arraySecond);
Console.WriteLine("A new array of strings that are less than or equal to 3 characters long: ");
ShowArray(arraySecond);
*/