//Метод который на вход берет массив, на выход кол-во строк у которых слова больше 5 символов
//string[] names = {"Ivan", "Anna", "Max", "Denis"};

/*
string[] CreateStringArray(int size)
{
    string[] words = new string[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} word");
        words[i] = Console.ReadLine();
    }
    return words;
}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int NumberOfLongWords(string[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    if(array[i].Length >= 5)
    count++;
    return count; 
}

Console.Write("Input number of names: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] names = CreateStringArray();

Console.WriteLine("Number of long word is  " + NumberOfLongWords);
*/


//Задача 2. Написать программу, которая принимает на вход два массива строк и возвращает
// массив из попарно объединенных исходных элементов.

string[] PairArray(string[] array1, string[] array2)
{
    string[] minArray = array1;
    string[] maxArray = array2;

    if(array2.Length < array2.Length) 
    {
         minArray = array2;
         maxArray = array1;
    }

     for(int i = 0; i < maxArray.Length; i++)
    {
        if(i < minArray.Length)
        newArray[i] +=  (" " + minArray[i]); //пробел
    }
    return maxArray;
}

string[] words1 = CreateStringArray(3);
string[] words2 = CreateStringArray(5);

string[] result = PairArray(words1, words2);
ShowArray(result);


//Задача 3. Написать программу, которая считает кол-во свло начинающихся на букву Y or W.

int IfYW (string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i][0] == 'y' || array[i][0] == 'w') count++;
        
        return count;
    }
}

string[] words = CreateStringArray(5);
Console.WriteLine(IfYW(words));