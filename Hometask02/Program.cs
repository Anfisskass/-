//Задача 1 Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.

/*

int FindSecNum(int num)
{
    int sot, ed;
    if(num >=100 && num <=999)

    sot = num/100;
    ed = num % 100 / 10;
    return ed;
}
else
{
    return -1;
}

Console.Write("Input three-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = FindSecNum(a);

Console.WriteLine("Second Number of " + a + " is " + result);

*/

//Задача 2
//Напишите программу, которая выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет
/* 
int FindThirdNum(int num)
{
    if(num<100)
    {
     Console.WriteLine("Third Number of " + num + " is absent");
    }

    while(999 <= num)
    {
        num = num / 10;
    }
    
    int sot, ed;
    if(num <= 999)
    sot = num/10;
    ed = num % 10;
    return ed;
}

Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = FindThirdNum(a);

Console.WriteLine("Third Number of " + a + " is " + result);
*/
 

//Задача 3
//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Input number from 1 to 7: ");
int day = Convert.ToInt32(Console.ReadLine());

void DayofWeek(int day)
{
    if(day == 6 || day == 7)
        Console.Write("day off");

    else if (day >=1 && day <= 5)
        Console.Write("working day");
}
DayofWeek(day);