// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();
int size = 7;
double[] array = new double[size];
void Fillarrayofrealnumbers (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble ()*100-50;
    }
}
Fillarrayofrealnumbers(array);
System.Console.WriteLine(string.Join(", ", array));

double DeltaMaxMinOffarray(double[] arr)
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
double m= DeltaMaxMinOffarray(array);
System.Console.WriteLine($"разница между максимальным и минимальным элементом равна : {m}");
