int[] Fibonachi(int num)
{
    int[] fibonachi = new int[num];
    // fibonachi[0] = 0;
    fibonachi[1] = 1;
    for (int i = 2; i < fibonachi.Length; i++)
    {
        fibonachi[i] = fibonachi[i-1] + fibonachi[i-2];
    }
    return fibonachi;
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

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] result = Fibonachi(number);
PrintArray(result);

