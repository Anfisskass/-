// Задача. Сгенерировать двумерный массив на основании 2х чисел, которые задаст пользователь. И загенерировать
// его случайными числами.

/*
int [,] CreateRandomTwoDemArray (int a, int b, int min, int max)
{
    int [,] newMatrix = new int [a, b];
    
    for(int i =0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
            newMatrix[i, j] = new Random().Next(min, max + 1);

            Console.Write(newMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}

int[,] array = CreateRandomTwoDemArray(4, 5, 1, 10);

*/

// Задача 2. Необходимо задать двумерный массив размером mxn каждый элемент которого в массиве находится 
// по формуле a[i, j] = i + j. Выведите полученный массив на экран.

/*
int [,] CreateArrayIJ (int a, int b)
{
    int [,] newMatrix = new int [a, b];
    
    for(int i =0; i < a; i++)
        for(int j = 0; j < b; j++)
            newMatrix[i, j] = i + j;
           
    return newMatrix;
}

void ShowTwoDimArray(int[,] array)
{
for(int i =0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            newMatrix[i, j] = i + j;

            Console.Write(newMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = CreateArrayIJ(4, 5);
*/

// Задача 3. Необходимо задать двумерный массив, и необходимо найти элементы, у которого оба индекса четные
// и заменить эти элементы на их квадраты.

/*
int [,] CreateRandomTwoDemArray (int a, int b, int min, int max)
{
    int [,] newMatrix = new int [a, b];
    
    for(int i =0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
            newMatrix[i, j] = new Random().Next(min, max + 1);

            Console.Write(newMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}

int[,] UpdateArrayEvenIndexQuand(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i =+ 2)
        for(int j = 0; j < array.GetLength(1); j =+ 2)
            //if(i % 2 == 0 && j % 2 == 0)
            array[i, j] *= array[i, j];
            
    return array;
}

int[,] Myarray = CreateRandomTwoDemArray(4, 5, 2, 15);

int[,] array = UpdateArrayEvenIndexQuand(4, 5);

*/

//Задача 4. Необходимо задать двумерный массив и необходимо найти сумму элементов на главной диагонали.
//(массив должен быть квадратным)

int[,] CreateArraySumDiagon(int a, int min, int max)
{
    int[,] newMatrix = new int [a, a];
    
    for(int i =0; i < a; i++)
    {
        for(int j = 0; j < a; j++)
        {
            newMatrix[i, j] = new Random().Next(min, max + 1);

            Console.Write(newMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}

int SumofDiagonal(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
            sum += array[i, i];
          
    return sum;
} 

int[,] Myarray = CreateArraySumDiagon(4, 2, 15);

Console.WriteLine(SumofDiagonal(Myarray));

