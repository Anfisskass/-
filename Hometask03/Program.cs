
/*
//Задача1 Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.WriteLine ("Input five-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

int Palindrom(int n)
{
    int temp;
    int b = 0;
    temp = n;

   while (temp != 0)
    {
          b = b * 10 + temp % 10; //Переворачиваем число по цифрам
          temp /= 10; //Отбрасываем последнюю цифру
    }
    if (n == b)
        Console.WriteLine("Palindrom");
    else
        Console.WriteLine("It is not a Palindrom");

    return 0;

}

Palindrom(n);
*/


//Задача2 (Напишите программу, которая принимает на вход координаты
//двух точек и находит расстояние между ними в 3D пространстве.)

double DistancePoint(double xa, double ya, double xb, double yb, double za, double zb)
{

return Math.Sqrt(Math.Pow((xb-xa), 2) + Math.Pow((yb-ya), 2) + Math.Pow((zb-za), 2)); 
// функция рассчитывает расстояние между точками с заданными координатами
}

Console.Write("Input coordinates xa: ");
double xa = Convert.ToDouble(Console.ReadLine());

Console.Write("Input coordinates ya: ");
double ya = Convert.ToDouble(Console.ReadLine());

Console.Write("Input coordinates za: ");
double za = Convert.ToDouble(Console.ReadLine());

Console.Write("Input coordinates xb: ");
double xb = Convert.ToDouble(Console.ReadLine());

Console.Write("Input coordinates yb: ");
double yb = Convert.ToDouble(Console.ReadLine());

Console.Write("Input coordinates zb: ");
double zb = Convert.ToDouble(Console.ReadLine());

double result = DistancePoint(xa, ya, xb, yb, za, zb);
Console.WriteLine($"Distance beetwen points {Math.Round(result, 2)}");

/*
//Задача 3 Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine ("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

void CubeN(int num)
{
    int count = 1;
       
    while (count <= num) 
    {
    Console.Write((count*count*count) + "  ");
    count++;
    }
}

CubeN(num);
*/