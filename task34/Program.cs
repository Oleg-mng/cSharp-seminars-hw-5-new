// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int size = 9;
int count=0;
int[] array = new int[size];
void Fillarray(int[] Arr, int size)
{
    for (int i = 0; i < size; i++)
    {
        Arr[i] = new Random().Next(100, 1000);
    }
}
int CountOddNumbers(int[] Arr, int size)
{
    for (int i = 0; i < size; i++)
    {
        if (Arr[i] % 2 == 0)
        {
            count++;
        }
    }
return count;
}
Fillarray(array, size);
System.Console.WriteLine($"Массив из 3-х значных чисел:");
System.Console.WriteLine(string.Join(", ", array));
CountOddNumbers(array, size);
Console.WriteLine($"Количество четных чисел: {count}");

