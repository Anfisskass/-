//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Input amount of numbers: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] UserNumbers = new int [M];


void EnterNumber (int M)
{
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine ($"Input {i + 1} numbers: ");
        UserNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int BiggerZero (int[] UserNumbers)
{
    int count = 0;
    for(int i = 0; i < UserNumbers.Length; i++)
    {
        if(UserNumbers[i] > 0) count+=1;
    }
    return count;
}

EnterNumber(M);

Console.WriteLine($"Numbers bigger than 0 are {BiggerZero(UserNumbers)}");



// Напишите программу, которая будет создавать копию заданного массива 
//с помощью поэлементного копирования.

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

int[] TheSameArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = array[i];
    }
    return array;
}

int [] arraynum1 = CreateRandomArray(10, 1, 12);
int [] arraynum2 = TheSameArray(arraynum1);

for(int i = 0; i < arraynum2.Length; i++)
{
    Console.Write(arraynum2[i] + " ");
}
*/