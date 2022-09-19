// написать программу которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.

string [] array = {"let", "me", "pass", "thistask"};

void secondArray (string [] array)
{
    string[] secondarr = new string [array.Length];
    for (int i = 0; i<array.Length; i++)
    {
        if(array[i].Length<=3)
        {
            secondarr[i]=array[i];
            Console.WriteLine(secondarr[i]);
        }
    }
    Console.WriteLine();
}


