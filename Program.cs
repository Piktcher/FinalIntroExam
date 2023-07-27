void CopyElementstoArray(string[] array)
{
    string[] array_new = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array_new[i] = array[i];
        }
    }

    for (int i = 0; i < array_new.Length; i++)
    {
        Console.Write(array_new[i] + ' ');
    }
}

string[] array = {"1234", "1567", "-222", "computer science"};
CopyElementstoArray(array);