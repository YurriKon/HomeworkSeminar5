/*
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[10];
Random rand = new Random();

void PrintArrayRand(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = rand.Next(1, 100);
        Console.Write($"{array[i]} ");
    }
}
Console.WriteLine("Массив случайных чисел:");
PrintArrayRand(array);
Console.WriteLine();

void PrintEvenSumArray(int[] array)
{
    int count = array.Length;
    int sum = 0;
    for (int i = 0; i < count; i++)
    {
        if (array[i]%2 == 0)
        {
            sum = sum + array[i];
        }
    }
    Console.WriteLine(sum);
}

Console.WriteLine("Сумма всех четных элементов:");
PrintEvenSumArray(array);
*/