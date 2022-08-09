int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);    
    }
    return arr;
}

void GetRiverse (int[] array)
{
  
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
   
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i == 0) Console.Write("[");
        if(i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
GetRiverse(array)
Console.Write(" -> ");
PrintArray(array);