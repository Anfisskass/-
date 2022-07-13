// Задайте двумерный массив. Напишите программу, которая упорядочит по 
//возрастанию элементы каждой строки двумерного массива.
/*
Console.Write("Input the number of an amount lines: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of an amount columns: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] CreateTwoDimArray(int a, int b, int min, int max)
{
    int[,] array = new int [a, b];
    
    for(int i = 0; i < a; i++)
        for(int j = 0; j < b; j++)
            array[i, j] = new Random(). Next(min, max + 1);
                    
     return array;
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

int [,] ReturnNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
        for (int count = 0; count < array.GetLength(1) - 1; count++)
        {
            if (array [i, count] > array[i, count + 1])
            {
                int temp = array[i, count + 1];
                array[i, count + 1] = array[i, count];
                array[i, count] = temp;
            }
        }
       }
    }
    return array;
} 

int [,] myArray = CreateTwoDimArray(a, b, min, max);
ShowArray(myArray);
myArray = ReturnNumbers (myArray);
Console.WriteLine();
ShowArray(myArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
Console.Write("Input the number of an amount lines: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of an amount columns: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a,b];
    for(int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max + 1);
          
        }
       
    }
    
    return newMatrix;
}
void PrintArray (int [,] array2)
{
     for(int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write (array2[i,j] + " ");
        }
        
        Console.WriteLine ();
    }    
}

int SmallSumElement (int[,] array)
{
    int minSum = 0;
    int minLine = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        
        if ( i == 0) minSum = sum;
        else if (sum < minSum)
        {
            minSum = sum;
            minLine = i;
        }
    }
    return minLine;
}

int [,] myArray = CreateRandomTwoDemArray(a, b, min, max);
PrintArray(myArray);
Console.WriteLine();
Console.WriteLine($"The line with the smallest number of elements: {SmallSumElement(myArray)}");

*/

 // Задача 62. Заполните спирально массив 4 на 4. Например, на выходе получается вот такой массив:
 // 1 2 3 4

// 12 13 14 5

// 11 16 15 6

// 10 9 8 7


void PrintArray (int [,] array2)
{
     for(int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write (array2[i,j] + " ");

        }
        
        Console.WriteLine ();
    }    

}

int[,] Spiral()
{
    int side = 4;
    int SideElement = 1;
    int[,] result = new int[side,side];
    int num = 1;
    for (int k = 0; k < side - SideElement  * 2; k++)
    {
        for (int j = k; j < side - SideElement  - k; j++, num++)
            result[k,j] = num;
        
        for (int i = k; i < side - SideElement  - k; i++, num++)
            result[i,side - SideElement  - k] = num;
        for (int j = side - SideElement  - k; j >= k; j--, num++)
            result[side - SideElement  - k,j] = num;
        for (int i = side - SideElement  * 2 - k; i > k; i--, num++)
            result[i,k] = num;
    }
    return result;
}
int[,] myArray = Spiral();
PrintArray(myArray);         
            
 