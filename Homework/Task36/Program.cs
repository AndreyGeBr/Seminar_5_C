// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

int[] array = CreateArray();
FillArray(array);
PrintArray(array);

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {SumOddNumbers(array)}");


int[] CreateArray()
{
    int[] array = new int [new Random().Next(4, 21)];
    return array;
}

void FillArray(int[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(0, 11);
    }
} 

void PrintArray(int[] arr)
{
    int count = arr.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(arr[i]);
        if (i == count - 1)
            Console.WriteLine("]");
        else
            Console.Write(",");
    }
    Console.WriteLine();
} 

int SumOddNumbers(int[] arr)
{   
    int sum = 0;
    for (int i = 0; i < arr.Length; i++) 
    {
       if (i % 2 != 0)
       sum = sum + arr[i];
    }
    return sum;
}