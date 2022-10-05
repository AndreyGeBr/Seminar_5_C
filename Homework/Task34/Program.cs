// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

int[] array = CreateArray();
FillArray(array);
PrintArray(array);

Console.WriteLine($"Количество четных чисел в массиве равно {CountEvenNumbers(array)}");


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
        arr[i] = random.Next(100, 1000);
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

int CountEvenNumbers(int[] arr)
{   
    int counter = 0;
    for (int i = 0; i < arr.Length; i++) 
    {
       if (arr[i] % 2 == 0)
       counter++;
    }
    return counter;
}