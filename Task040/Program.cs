Console.WriteLine("Введите первое число: ");
int firstLength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondLength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int thirdLength = Convert.ToInt32(Console.ReadLine());

bool IsExistTriangle(int a, int b, int c)
{
    return (a + b) >= c && (b + c) >= a && (c + a) >= b;
}

bool result = IsExistTriangle(firstLength, secondLength, thirdLength);
Console.WriteLine(result ? "Треугольник существует" : "Треугольник не существует");