// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] array)
{
    Random rnd = new Random();
    for(int index = 0; index < array.Length; index++)
    array[index] = rnd.Next(1, 10);
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}

int[] newArray = new int[8];
FillArray(newArray);
PrintArray(newArray);