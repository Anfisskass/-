/*
int FindQuart(int x, int y)
{
    if(x>0 && y>0) return 1;
    if(x<0 && y>0) return 2;
    if(x<0 && y<0) return 3;
    if(x>0 && y<0) return 4;

    return -1;
}

int result = FindQuart(2,4);

if (result == -1) Console.WriteLine("Данная точка расположена на осях");
else Console.WriteLine($"Точка находится в {result} четверти");
*/

/*//Задача1

void Diapazon (int quart)
{
    if (quart == 1) Console.WriteLine("Координаты x>0, y>0");
    if (quart == 2) Console.WriteLine("Координаты x<0, y>0");
    if (quart == 3) Console.WriteLine("Координаты x<0, y<0"):
    if (quart == 4) Console.WriteLine("Координаты x>0, y<0")
}
Diapazon(num);
*/

//Задача 2



/*

Console.WriteLine ("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

void QuandN (int num)
{
    int count = 1;
    
    while (count <= num) 
    {
     Console.WriteLine ((count*count) + " ");
     count++;
    }
}

QuandN(num);
*/

double FindLenght(double xA, double xB, double yB, double yA)
{
    return Math.Sqrt((xB - xA) * (xB - xA) + Math.Pow((yB - yA), 2));
}

Console.WriteLine ("Input integer number: ");
int num1 = Convert.ToDouble;

Console.WriteLine ("Input integer number: ");
int num2 = Convert.ToDouble;