/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

double [] MakeRandomArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble();
    }
    return array;
}


void PrintArray (double[] array)
{
    Console.WriteLine("Случайный массив:");
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}


void MaxMinDiff (double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if(array[i] < min)
        {
            min = array[i];
        }
    }
    double result = max - min;
    Console.WriteLine($"Разница между максимальным и минимальны значиениями массива составляет {result}.");
}

Console.Clear();
System.Console.WriteLine("Укажите длину массива.");
int arrayLength = Convert.ToInt32(Console.ReadLine());
double[] myArray = new double[arrayLength];
myArray = MakeRandomArray(myArray);
PrintArray(myArray);
MaxMinDiff(myArray);