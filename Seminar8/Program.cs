//Задача. Необходимо задать двумерный массив и написать программу которая поменяет
// местами 1ю и последнюю строки этого массива
/*
int[,] CreateTwoDimArray(int m, int n, int min, int max)
{
    int[,] array = new int [m, n];
    
    for(int i =0; i < m; i++)
        for(int j = 0; j < n; j++)
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

int[,] ChangeLines(int[,] array, int strIndex1, int strIndex2)
{
    int temp;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[strIndex1, j];
        array[strIndex1, j] = array[strIndex2, j];
        array[strIndex2, j] = temp;
    }
    return array;
}

int[,] myArray = CreateTwoDimArray(4,5,1,9);
ShowArray(myArray);
myArray = ChangeLines(myArray, 0, myArray.GetLength(0) - 1);
Console.WriteLine();
ShowArray(myArray);

*/

//Задача 2. Необходимо задать двумерный массив и написать программу, которая заменяет строки
// на столбцы. В случае если это невозможно, она должна вывести сообщение, что Нельзя.
/*
123
456
789

147
258
369
*/
/*
int[,] CreateTwoDimArray(int m, int n, int min, int max)
{
    int[,] array = new int [m, n];
    
    for(int i =0; i < m; i++)
        for(int j = 0; j < n; j++)
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

int[,] ChangeRowsColumns(int[,] array)
{
     for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
}

int[,] myArray = CreateTwoDimArray(4,5,1,9);
ShowArray(myArray);
*/

//Задача 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении
// которых расположен наименьший элемент
/*
4263
8357
7345

0000
8057
7045
*/

int[,] CreateTwoDimArray(int m, int n, int min, int max)
{
    int[,] array = new int [m, n];
    
    for(int i =0; i < m; i++)
        for(int j = 0; j < n; j++)
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

int[,] DeleteRowColumn(int[,] array)
{
    int minRow = 0; 
    int minColumn = 0;
    int min = array[minRow, minColumn];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] < min) 
            {
                min = array[i, j];
                minRow = i;
                minColumn = j;
            }
        }
    }
}

