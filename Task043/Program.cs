// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите коэффициент k первой прямой: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент b первой прямой: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент k второй прямой: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент b второй прямой: ");
int b2 = Convert.ToInt32(Console.ReadLine());

double[] PointDefenition(int k1, int b1, int k2, int b2)
{
    double[] arr = new double[2];
    arr[0] = (b2 - b1) / (k1 - k2);
    arr[1] = arr[0] * k1 + b1;
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double[] result = PointDefenition(k1, b1, k2, b2);
PrintArray(result);
