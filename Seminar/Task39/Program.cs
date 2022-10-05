// Программа, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

Console.Clear();

int[] array1 = CreateArray();
FillArray(array1);
PrintArray(array1);
int[] result = ReverseArray(array1);
PrintArray(result);


int[] CreateArray()
{
    int[] array = new int [new Random().Next(2, 10)];
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

int[] ReverseArray(int[] arr)
{   
    int[] result = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++) // записали в новый массив элементы первого массива
    {
       result[i] = arr[arr.Length -1 - i]; 
    }
    return result;
}
