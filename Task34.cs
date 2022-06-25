//Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int[20];
Random rand = new Random();

void PrintArrayRand(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = rand.Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
}
Console.WriteLine("Массив случайных трехзначных чисел:");
PrintArrayRand(array);
Console.WriteLine();
void SortArray(int[] array)
{
for (int i = 0; i < array.Length - 1; i++)
{
    int minPosition = i;
    for (int j = i + 1; j < array.Length; j++)
    {
       if (array[j] < array[minPosition])
       {
        minPosition = j;
       }
    }
    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
}
}

void PrintArraySorted(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

SortArray(array);
Console.WriteLine("Отсортированный массив:");
PrintArraySorted(array);


    Console.WriteLine();
    Console.WriteLine("Разность между максимальным и минимальным значениями:");
    int deduction = array[array.Length -1] - array[0];
    Console.WriteLine(deduction);
