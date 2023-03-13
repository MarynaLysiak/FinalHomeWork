
string[] FindArrayResult(string[] arr1)
{
    int count = 0;
    string[] arr2 = new string [arr1.Length];
    for (int i = 0; i < arr1.Length; i++)
    {
    if (arr1[i].Length <= 3)
    {
    arr2[count] = arr1[i];
    count++;
    }
    } 
    return arr2;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
}


string[] array1 = new string[4] {"hello", "2", "World", ":-)"};
PrintArray(array1);
System.Console.WriteLine("Массив с элементами в 3 или менее символов:");
string[] arrayResult = FindArrayResult(array1);
PrintArray(arrayResult);



