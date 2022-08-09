double[] CreateArrayRndInt (int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * 100;    
    }
    return arr;
}

double GetMax (double[] array)
{
    double maximum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maximum)
        maximum = array[i];
    }
    return maximum;
}

double GetMin (double[] array)
{
    double minimum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minimum)
        minimum = array[i];
    }
    return minimum;
}

double GetDif (double min, double max)
{
    double dif = max - min;
    return dif;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i == 0) Console.Write("[");
        if(i < array.Length - 1) Console.Write(Math.Round(array[i],1) + "; ");
        else Console.Write(Math.Round(array[i],1) + "]");
    }
}

double[] array = CreateArrayRndInt(4, -100, 100);
PrintArray(array);
double max = GetMax(array);
double min = GetMin(array);
double res = GetDif(min, max);
Console.WriteLine(" -> ");
Console.WriteLine(Math.Round(res,1));
