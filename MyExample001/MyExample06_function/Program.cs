// Найти максимальное число из девяти при помощи функции
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 15, b1 = 20, c1 = 18,
    a2 = 231, b2 = 5, c2 = 6,
    a3 = 8, b3 = 1000, c3 = 10;

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);