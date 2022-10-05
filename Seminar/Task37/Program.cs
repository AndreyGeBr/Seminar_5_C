// Напишите метод, который объединяет 2 массива в 1. 
Console.Clear();

int[] array1 = CreateArray();
FillArray(array1);
PrintArray(array1);
int[] array2 = CreateArray();
FillArray(array2);
PrintArray(array2);
int[] result = AddArray(array1, array2);
PrintArray(result);


int[] CreateArray()
{
    int[] array = new int [new Random().Next(4, 6)];
    return array;
}

void FillArray(int[] num)
{
    Random random = new Random();
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = random.Next(0, 10);
    }
} 

void PrintArray(int[] num)
{
    int count = num.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(num[i]);
        if (i == count - 1)
            Console.WriteLine("]");
        else
            Console.Write(",");
    }
    Console.WriteLine();
} 

int[] AddArray(int[] arr1, int[] arr2)
{   
    int[] sum = new int[arr1.Length + arr2.Length];
    for (int i = 0; i < arr1.Length; i++) // записали в новый массив элементы первого массива
    {
       sum[i] = arr1[i]; 
    }
     for (int i = arr1.Length; i < (arr1.Length + arr2.Length); i++) // дописали в новый массив элементы второго массива
    {
       sum[i] = arr2[i - arr1.Length]; 
    }
    return sum;
}