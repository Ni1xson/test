
string[] ArrayOne = new string[5] { "2", "helly", "hello", "world", "43" };
string[] ArrayTwo = new string[ArrayOne.Length];
void SecondArray(string[] ArrayOne, string[] ArrayTwo)
{
    int count = 0;
    for (int i = 0; i < ArrayOne.Length; i++)
    {
        if (ArrayOne[i].Length <= 3)
        {
            ArrayTwo[count] = ArrayOne[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(ArrayOne, ArrayTwo);
PrintArray(ArrayTwo);