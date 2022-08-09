Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());

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

void IfNumInArr(int [] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] == number) 
       {
        Console.WriteLine("да");
       }
    }   
    Console.WriteLine("нет");
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
Console.Write(" -> ");
IfNumInArr(array, num);
