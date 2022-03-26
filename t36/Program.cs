/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

//0 не является ни четным ни нечетным, поэтому считать будем 1,3,5...

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

int [] MakeRandomArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 1000); //диапазон случайных чисел задачей не задан, возьмем от 1 до 999
    }
    return array;
}


void CountNumbersInOddPositions (int [] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i+=2) //array[0] будем считать нулевой позицией, а следовательно первая нечетная позиция array[1], поэтому стартовый i = 1
    {
        result += array[i];
    }
    Console.WriteLine(result);
}


Console.Clear();
System.Console.WriteLine("Укажите длину массива.");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[arrayLength];
myArray = MakeRandomArray(myArray);
PrintArray(myArray);
CountNumbersInOddPositions(myArray);