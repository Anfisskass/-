
/*
int num1, num2;
Console.Write("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("first integer is more = "+num1);
}
else
{
    Console.WriteLine("second integer is more = "+num2);
}
*/

/*
int num1, num2, num3, max;

Console.Write("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third integer number: ");
num3 = Convert.ToInt32(Console.ReadLine());

max = num1;

if (num2 > num1)
{
    max = num2;
}
if (num3 > num2)
{
    max = num3;
}
Console.WriteLine("Max = "+max);
*/

/*
int num;
Console.Write("Input integer number: ");
num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");   
}
*/

int num;

Console.Write ("Input integer number: ");
num = Convert.ToInt32(Console.ReadLine());

int current = 2;

while(current <= num)
{
    Console.Write(current + " ");
    current= current + 2; 
}