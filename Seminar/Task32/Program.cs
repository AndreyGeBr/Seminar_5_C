// Программа замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

Console.Clear();

Console.WriteLine("Введите числа через пробел");

string input = Console.ReadLine()!;
int[] array =  ParseToArray(input);
PrintArray(array);
InverseArray(array);
PrintArray(array);



int[] ParseToArray (string str)
{
    string[] stringArray = str.Split(" ");
    int[] result = new int[stringArray.Length];

    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = int.Parse(stringArray[i]);
    }

    return result;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i]);
        if (i == count - 1)
            Console.WriteLine("]");
        else
            Console.Write(",");
    }
    Console.WriteLine();
} 

void InverseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = - array[i];
    }
}