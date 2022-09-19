// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArray()
{
    Random rnd = new Random(); 
    double[] array = new double[8]; 
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(10,100)/10.0; 
    }
    return array;
}


void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} \t"); 
    }
}


double DifferenceMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];    
        if (array[i] < min) min = array[i];         
    }      
    return max - min; 
}

double [] arr = CreateArray();
PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"The different between max and min: {DifferenceMaxMin(arr)}"); 