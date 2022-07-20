// Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.

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


int VowelsLetters (string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i][0] == 'a'|| == array[i][0] == 'e' || array[i][0] == 'i' || array[i][0] == 'o' || array[i][0] == 'u' || array[i][0] == 'y') 
        count++;
        
        return count;
    }
}

string[] words = CreateStringArray(5);
Console.WriteLine(VowelsLetters(words));


// Задайте массив строк. 
//Напишите программу, которая генерирует новый массив, 
// объединяя элементы исходного массива попарно.

//Задача 2. Написать программу, которая принимает на вход два массива строк и возвращает
// массив из попарно объединенных исходных элементов.
/*
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
*/
