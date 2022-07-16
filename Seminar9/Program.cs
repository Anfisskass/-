// Задача 1. Необходимо написать программу которая выведет все натуральные числа
// в промежутке от 1 до N. При имеющейся величине N.

/*
void ShowNums(int n)
{
    if(n != 1)
    ShowNums(n - 1);

    Console.Write(n + " ");
}

Console.Write("Input integer positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowNums(num);
*/


// Необходимо вывести числа от M до N. 
/*
void ShowNums(int m, int n)
{
    if(m != n)
    ShowNums(m - 1, n);

    Console.Write(m + " ");
}

Console.Write("Input integer min number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input integer max number: ");
int m = Convert.ToInt32(Console.ReadLine());

ShowNums(m, n);
*/

// Необходимо написать программу которая будет принимать на вход число
// и возвращать сумму его цифр.

/*
int SumEnterNum (int num)
{
    if(num == 0)
    return 0;
    return num % 10 + SumEnterNum(num / 10);
    

}

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumEnterNum(num));
*/

//Необходимо число а возвести в степень b

int Degree (int a, int b)
{
    if (b != 0)
    return a * Degree(a, b-1);
    else
    return 1;
}

Console.Write("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input integer number: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Degree(a, b));