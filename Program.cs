int[] ints = { 0, 2, 1, 1, 9, 1, 1 };
Console.Write("Original ");
PrintArray(ints);

ReplaceOnesWithZeros(ints);
Console.Write("Changed ");
PrintArray(ints);

void PrintArray(int[] arr)
{
    Console.Write("Array: [");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i != arr.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

void ReplaceOnesWithZeros(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] == 1 && arr[i+1] == 1)
        {
            arr[i] = 0;
            arr[i+1] = 0;
            return;
        }
    }
    return;
}