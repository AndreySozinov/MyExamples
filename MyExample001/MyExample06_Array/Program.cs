// Найти максимальное число из массива при помощи функции
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

void FillArray(int[] collection) {
    int len = collection.Length;
    int index = 0;
    while (index < len) {
        collection[index] = new Random().Next(1, 999);
        index++;
    }
}

void PrintArray(int[] col) {
    int count = col.Length;
    int index = 0;
    while (index < count) {
        Console.WriteLine(col[index]);
        index++;
    }
}

int[] arr = new int[9];
FillArray(arr);
PrintArray(arr);

int result = Max(
    Max(arr[0], arr[1], arr[2]), 
    Max(arr[3], arr[4], arr[5]),
    Max(arr[6], arr[7], arr[8])
);
Console.WriteLine();
Console.WriteLine($"Максимальное число = {result}");
