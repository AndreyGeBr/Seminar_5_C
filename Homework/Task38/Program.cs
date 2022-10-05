// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();

double[] array = CreateArray();
FillArray(array);
PrintArray(array);
double result = Math.Round(FindMax(array) - FindMin(array), 2);
Console.Write($"разница между максимальным и минимальным элементами равна {FindMax(array)} - {FindMin(array)} = {result}");


double[] CreateArray()
{
    Random random = new Random();
    double[] array = new double [random.Next(4, 11)];
    return array;
}

void FillArray(double[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(random.NextDouble() * 10, 2);
    }
} 

void PrintArray(double[] arr)
{
    int count = arr.Length;
    Console.Write("В массиве : [");
    for (int i = 0; i < count; i++)
    {
        Console.Write(arr[i]);
        if (i == count - 1)
            Console.WriteLine("]");
        else
            Console.Write("  ");
    }
    //Console.WriteLine();
} 

double FindMin(double[] arr)
{    
    int i = 0;   
    double min = arr[i];
    for (i = 0; i < arr.Length; i++) 
    {
       if (arr[i] < min)
       min = arr[i];
    }
    return min;
}

double FindMax(double[] arr)
{   
    int i = 0;
    double max = arr[i];
    for (i = 0; i < arr.Length; i++) 
    {
       if (arr[i] > max)
       max = arr[i];
    }
    return max;
}