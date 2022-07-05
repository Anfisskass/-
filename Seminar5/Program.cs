// Необходимо создать массив из 12 элементов, заполнить случайными числами
// промежутком от -9 до 9, найти отрицательную сумму элементов массива и сумму положительных



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

int FindPositiveSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum += array[i]; // sum = sum + array[i]
    }
    return sum;
}

int FindNegativeSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sum += array[i];
    }
    return sum;
}

Console.WriteLine ("Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Input max number: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Input max number: ");
int min = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);

Console.WriteLine("Sum of positivenumbers is  " + FindPositiveSum(myArray));

Console.WriteLine("Sum of negativenumbers is  " + FindNegativeSum(myArray));


// Задача 2. Необходимо написать программу замену элементов массива - положительные на отрицательные и
// отрицательные на положительные


/*

int[] ChangeNums(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    array[i] *= -1;
    }
    return array;
  
}

*/

// Задача 3. Необходимо написать программу, которая определит присутствиует ли число в массиве

bool FindNumberinArray(int[] array, int aa)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == aa) return true;
    }
    return false; 
}

int find = 16;
Console.WriteLine("В массиве число " + find + ((FindNumberinArray(myArray, find))? " присутствует " : " не присутствует "));

// Задача 4. Необходимо задать одномерный массив из 12 элементов случайных чисел найти количество элементов
// значений которые лежат от 10 до 99 включительно

int FindCountElementsInRange(int[] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= min && array[i] <= max) count++; //если два таких знака, то получив false в первом блоке, вообще дальше не пойдет
    }
    return count;
}

int minimum = 10;
int maximum = 99;

Console.WriteLine("Количество цифр в отрезке " + minimum + " до " + maximum + " = " + FindCountElementsInRange(myArray, minimum, maximum));
