Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите основание системы счисления: ");
int baseNumber = Convert.ToInt32(Console.ReadLine());

int DecToBaseNum(int number, int baseNum)
{
    int result = 0;
    int mult = 1;
    while (number > 0)
    {
        result += number % baseNum * mult;
        number = number / 2;
        mult *= 10;
    }
    return result;
}

int res = DecToBaseNum(number, baseNumber);
Console.WriteLine(res);