
//Задача Напишите программу, которая принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B

/*
Console.WriteLine ("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int a, int b)
{
    int num1 = a;
    int count = 1;
    while(count < b)
    {
    num1 = num1 * a;
    count++;
    }   
    
    return num1;
}

double result = Exponentiation(a, b);

Console.WriteLine($"{a} in dergree {b} is {result}");

*/

// Задача  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 3, 44, 3 -> [1, 2, 5, 7, 19, 3, 44, 3]



int size = 8;
int[] array = new int [size];

for(int i = 0; i < size; i++)
{
array[i] = new Random().Next(0,9);
}
for(int i = 0; i < size; i++)
{
    Console.Write(array[i] + " ");
}
