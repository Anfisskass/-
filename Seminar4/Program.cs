/*
int FindSumofDigits(int num)
{
    int sum = 0;

    while(num>0)
    {
    sum = sum + num % 10; // sum += num 10%; то же самое; sum -= num 10% уменьшить
    num = num / 10; // num /= 10;
    }
    return sum;
}
Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = FindSumofDigits(n);

Console.WriteLine($"Sum of numbers {n} = {result}");
*/

/* 
int SumTillA(int A)
{
    int current = 1;
    int sum = 0;
    
    while(current <= A)
    {
    sum = sum + current; 
    current++;
    }
    return sum;
}
Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = SumTillA(n);

Console.WriteLine($"Sum of numbers {n} = {result}");
*/


/* int FindMult(int A)
{
    int current = 1;
    int mult = 1;
    
    while(current <= A)
    {
    mult = mult * current; 
    current++;
    }
    return mult;
}
Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = FindMult(n);

Console.WriteLine($"Sum of numbers {n} = {result}");

*/

//Задача 3

/*
void FindAmountofDigital(int a)
{
    int counter = 0;

    while(a>0)
    {
    a = a / 10;
    counter = counter + 1;
    }
Console.Writeline(counter);
}
Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = FindAmountofDigitaL(n);

Console.WriteLine(result);
*/

int size = 8;
int[] array = new int [size];

for(int i = 0; i < size; i++)
{
array[i] = new Random().Next(0,2);
}
for(int i = 0; i < size; i++)
{
    Console.Write(array[i] + " ");
}