// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


int[] CreateArray()
{
    Random rnd = new Random(); 
    int[] array = new int[8]; 
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100,1000); 
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


int FindEvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
            
    }       
    return count; 
}

int[] arr = CreateArray();
PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"Number of even numbers: {FindEvenNumber(arr)}"); 
