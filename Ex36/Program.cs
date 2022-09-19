// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateArray()
{
    Random rnd = new Random(); 
    int[] array = new int[8]; 
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-10,10); 
    }
    return array;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} \t"); 
    }
}


int SumUnevenIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i];             
    }      
    return sum; 
}

int[] arr = CreateArray();
PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"Sum of numbers with uneven index: {SumUnevenIndex(arr)}"); 