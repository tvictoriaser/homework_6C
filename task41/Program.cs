// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите через пробел числа: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int NumbersMoreZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int numbersMoreZero = NumbersMoreZero(arr);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"Количество чисел больше 0 -> {numbersMoreZero}");
