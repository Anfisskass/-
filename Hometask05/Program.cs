// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
 int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int [size];
    
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max);

        Console.Write(newArray[i] + "  ");
    }
    Console.WriteLine();

    return newArray;
}

int FindPositiveCount(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
      if(array[i] % 2 == 0)
      count = count + 1;
    }
    return count;   
   
}


int[] myArray = CreateRandomArray(5, 100, 999);

Console.Write("Amount of positivenumbers is  " + FindPositiveCount(myArray));
*/

// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях

/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int [size];
    
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max +1);

        Console.Write(newArray[i] + "  ");
    }
    Console.WriteLine();

    return newArray;
}

int FindOddNumber (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 !=0) 
        sum += array[i];
    }
    return sum;
    
}

int[] myArray = CreateRandomArray(5, 1, 100);

Console.Write("Sum of elements of negative is  " + FindOddNumber(myArray));
*/

//Задайте массив вещественных(дробных, см. Random().NextDouble()) чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.


    double[] array = new double [10];
    for (int i = 1; i < array.Length; i++)
    {
    array[i] = Math.Round(new Random().Next(1, 15) + new Random().NextDouble(),1);

        Console.Write(array[i] + "  ");
    }

    double maxElement = array[0];
    double minElement = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if(maxElement < array[i]) 
        {
            maxElement = array[i];
        }
        if(minElement > array[i])
        {
            minElement = array[i];
        }
    }
    
double difference = maxElement - minElement;

Console.WriteLine($"Difference between max and min of elements is {difference}");

