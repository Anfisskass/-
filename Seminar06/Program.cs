/*
int[] ReserseArray(int[] array)
{
    int temp;
    int j = array.Length - 1, i = 0;
    
    while(i < j)
    {
        temp = array[i];
        array [i] = array [j];
        array [j] = temp;

        i++;
        j--;
    }
    return array;
}

int[] newArray = {1, 2, 3, 4, 5};

newArray = ReserseArray(newArray);

for(int i = 0; i < newArray.Length; i++)
{
    Console.Write(newArray[i] + " ");
}


Console.WriteLine ("Input numbers: ");
int M = Convert.ToInt32(Console.ReadLine());
*/


//Задача 2. Напишите программу, которая принимает на вход три числа и проверяет, может ли 
// существовать треугольник со сторонами такой длины. a + b > c.
/*
void Triangle(int a, int b, int c)
{
    if(a + b > c && a + c > b && c + b > a)
    Console.WriteLine("The triangle is possible");
    else 
    Console.WriteLine("The triangle is impossible");
}

int a = 3;
int b = 5;
int c = 7;
Triangle(a, b, c);
*/

//Задача 3. Не используя рекурсию, выведите первые N числа Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// F(n) = F(n-1)+F(n-2)

/*
void Fibonacci(int n)
{
    int[] array = new int [n];
    array[0] = 0;
    array[1] = 1;
    Console.Write(array[0] + " " + array[1] + " ");

    for(int i = 2; i < n; i++)
    {
        array [i] = array[i - 1] + array[i - 2];
        Console.Write(array[i] + " ");
    }
}

int n = 5;
Fibonacci(n);
*/

// Задача 4. Напишите программу, которая будет пробразовывать десятичное число в двоичное

string BinaryNumber(int num)
{
    string result = string.Empty;
    while(num > 0)
    {
        result = num % 2 + result;
        num /= 2;
    }
    return result;
}

Console.WriteLine(BinaryNumber(41));
