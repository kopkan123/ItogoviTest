string[] arr = new string[5] {"Russia", "Denmark", "hello", "world", "1234"};
string[] arr2 = new string[arr.Length];
void Voidss(string[] arr, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
    if(arr[i].Length <= 3)
        {
        arr2[count] = arr[i];
        count++;
        }
    }
}
void Voidss2(string[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}
Voidss(arr, arr2);
Voidss2(arr2);