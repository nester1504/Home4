int[] array = new int [8];

void RandomNumber(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100);
    }
}

void WriteArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"[{arr[i]}] " );
    }
}

RandomNumber(array);
WriteArray(array);