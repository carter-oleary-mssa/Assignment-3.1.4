int[] ints = { 0, 2, 1, 1, 9, 1, 1 };
int[] changedInts = ReplaceOnesWithZeros(ints);

Console.Write($"Original Array: [");
for(int i = 0; i < ints.Length; i++)
{
    Console.Write(ints[i]);
    if(i != ints.Length-1 )
    {
        Console.Write(",");
    }
}
Console.WriteLine("]");
Console.Write($"Changed Array: [");
for (int i = 0; i < changedInts.Length; i++)
{
    Console.Write(changedInts[i]);
    if (i != changedInts.Length - 1)
    {
        Console.Write(",");
    }
}
Console.WriteLine("]");

int[] ReplaceOnesWithZeros(int[] arr)
{
    List<int> newArr = arr.ToList();
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] == 1 && arr[i+1] == 1)
        {
            newArr[i] = 0;
            newArr[i+1] = 0;
            return newArr.ToArray();
        }
    }
    return arr;
}