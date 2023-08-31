// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]:F2} | ");
        else Console.Write($"{arr[i]:F2}");
    }
    Console.Write("]");
}

double MaxElem(double[] arr)
{
    double max=arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max=arr[i];
    }
    return max;
}


double MinElem(double[] arr)
{
    double min=arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min=arr[i];
    }
    return min;
}


double Difference(double max, double min)
{
    return (max-min);
}



double[] array = CreateArrayRndDouble (4, -99, 99);
PrintArrayDouble(array);
double maximum= MaxElem(array);
double minimum= MinElem(array);
double diff=Difference(maximum, minimum);
Console.Write($" -> {maximum:F2} - ({minimum:F2}) = {diff:F2}");
