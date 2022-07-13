
// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int size = 7;
int[] array = new int[size];
void Fillarray(int[] arr, int size)
{
    //int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
}
Fillarray(array, size);
System.Console.WriteLine($"Получили массив из случайных чисел:");
System.Console.WriteLine(string.Join(", ", array));

int SumOddNumbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}
int sum = SumOddNumbers(array);
System.Console.WriteLine($"Сумма элементов стоящих на нечетных позициях: {sum}");
