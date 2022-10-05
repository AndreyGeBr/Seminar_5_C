// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Напишите две функции:
// найти сумму положительных чисел
// найти сумму отрицательных чисел

Console.Clear();
Console.WriteLine("Введите числа через пробел");

string input = Console.ReadLine()!;
int[] array =  ParseToArray (input);

Console.WriteLine($"Сумма положительных чисел равна {PositiveSum(array)}");
Console.WriteLine($"Сумма отрицательных чисел равна {NegativeSum(array)}");





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

int PositiveSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] > 0)
       sum += array[i]; 
    }

    return sum;
}

int NegativeSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] < 0)
       sum += array[i]; 
    }

    return sum;
}
