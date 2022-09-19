// написать программу которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.

string[] array = { "let", "me", "pass", "thistask" };
PrintArray(array);
SecondArray(array);


void PrintArray(string[] Array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(Array[i]);
    }
    Console.WriteLine();
}

void SecondArray(string[] array)
{
    string[] secondarr = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 4)
        {
            secondarr[i] = array[i];
            Console.WriteLine(secondarr[i]);
        }
    }
    Console.WriteLine();
}



