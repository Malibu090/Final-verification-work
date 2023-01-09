string[] arr = { "dfgsgh", "dfg", "ljhnsad", "A", "3e2", "43kfgkl657", "gltehie45skf", "31" };
int sizeArrayOutput = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3)
    {
        sizeArrayOutput += 1;
    }
}

void FillAndOutputArrayString(string[] arr)
{
    string[] arrayOutput = new string[sizeArrayOutput];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arrayOutput[count] = arr[i];
            count++;
        }
    }
    System.Console.WriteLine("Массив строк, длина которых меньше или равна трём");
    Console.WriteLine('[' + string.Join("; ", arrayOutput) + ']');
}

System.Console.WriteLine("Начальный массив строк");
Console.WriteLine('[' + string.Join("; ", arr) + ']');
FillAndOutputArrayString(arr);