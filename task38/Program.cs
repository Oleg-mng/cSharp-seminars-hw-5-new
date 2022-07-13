// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();
double size = 5;
//double[] array = new double[size];
double[] array = {-2, 1, 5.3, 7.6, -1.23};

System.Console.WriteLine(string.Join(", ", array));
double DeltaMaxMinOffarray(double[] arr, double size)
{
    double max = 0;
    double min = 112;
    for (int i = 0; i < size; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
            //max = (Arr[i] > max) ? Arr[i] : 0;
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    double m = max- min;
    return m;

}
double m= DeltaMaxMinOffarray(array, size);
System.Console.WriteLine($"разница между максимальным и минимальным элементом равна : {m}");
