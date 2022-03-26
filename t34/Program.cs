/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */


int [] MakeRandomArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}


void CountEvenNumbers (int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] %2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество четных чисел в этом массиве = {count}.");
}


void PrintArray (int[] array)
{
    Console.WriteLine("Случайный массив:");
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}


Console.Clear();
System.Console.WriteLine("Укажите длину массива.");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[arrayLength];
myArray = MakeRandomArray(myArray);
PrintArray(myArray);
CountEvenNumbers(myArray);
