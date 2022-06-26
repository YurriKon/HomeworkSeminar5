

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

void SumEvenArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i]%2 == 0) count++;
        
    }
    Console.WriteLine($"Количество четных элементов: {count}");
    

}

SumEvenArray(array);
