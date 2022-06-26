/*
// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[10];
Random rand = new Random();

void PrintArrayRand(double[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = rand.NextDouble()*100;
        Console.Write($"{array[i]} ");
    }
}
Console.WriteLine("Массив случайных вещественных чисел:");
PrintArrayRand(array);
Console.WriteLine();
void SortArray(double[] array)
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
    double temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
}
}

void PrintArraySorted(double[] array)
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
    double deduction = array[array.Length -1] - array[0];
    Console.WriteLine(deduction);

*/