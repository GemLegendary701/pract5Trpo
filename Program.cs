static bool IsPalindrome(int num)
{
    int num1 = num;
    int num2 = 0;
    while (num > 0)
    {
        num2 = num2 * 10 + num % 10;
        num /= 10;
    }
    return num1 == num2;
}
static int SumOfOddDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int digit = num % 10;
        if (digit % 2 != 0)
        {
            sum += digit;
        }
        num /= 10;
    }
    return sum;
}
static int SumOfEvenDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int digit = num % 10;
        if (digit % 2 == 0)
        {
            sum += digit;
        }
        num /= 10;
    }
    return sum;
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int iteration = 0;
bool isEven = true;
while (!IsPalindrome(n) && iteration < 1000)
{
    int sumToAdd = 0;
    if (isEven)
    {
        sumToAdd = SumOfEvenDigits(n);
        Console.WriteLine($"Шаг {iteration}. сумма четных: {sumToAdd}");
    }
    else
    {
        sumToAdd += SumOfOddDigits(n);
        Console.WriteLine($"Шаг {iteration}. сумма нечетных: {sumToAdd}");
    }
    n += sumToAdd;
    Console.WriteLine("Текущее число: " + n);
    isEven = !isEven;
    iteration++;
}
    if (IsPalindrome(n))
    {
        Console.WriteLine("Палиндром найден: " + n);
    }
    else
    {
        Console.WriteLine("Достигнут лимит шагов");
    }