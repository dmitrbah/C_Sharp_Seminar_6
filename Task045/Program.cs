﻿int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int[] CopyArray(int[] arr)
{
    int[] copy = new int [arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copy[i] = arr[i];
    }
    return arr;
}

int[] firstArray = CreateArrayRndInt(8, 0, 10);
PrintArray(firstArray);
int[] secondArray = CopyArray(firstArray);
PrintArray(secondArray);
