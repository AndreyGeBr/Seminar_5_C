// Напишите метод, который суммирует 2 массива. Каждый элемент одного массива должен суммироваться с соответствующим элементом из второго массива. 
// Если длины массивов не равны, то должно появляться сообщение об ошибке

Console.Clear();

int[] array1 = CreateArray();
FillArray(array1);
PrintArray(array1);
int[] array2 = CreateArray();
FillArray(array2);
PrintArray(array2);
if (array1.Length == array2.Length)
{
    int[] result = SumArray(array1, array2);
    PrintArray(result);
}
else
{
    Console.WriteLine("Массивы разной длины");
}


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

int[] SumArray(int[] arr1, int[] arr2)
{
    int[] sum = new int[arr1.Length];
    for (int i = 0; i < arr1.Length; i++)
    {
       sum[i] = arr1[i] + arr2[i]; 
    }
    return sum;
}