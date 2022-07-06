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
