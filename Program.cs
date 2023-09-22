string[] EnterNewArray(int size) //, int minValue, int maxValue)
 {
                
    string[] array = new string[size]; 
    for (int i = 0; i < size; i++) 
        {
            Console.WriteLine($"Введите элемент массива под индексом {i}");
            array[i] = Console.ReadLine();     
        }                           
         return array;
}

void WriteArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
}           

string[] Char3OrMore(string[] array)
{
    string[] newArray = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}



Console.WriteLine("Введите размер массива: ");
int size1 = Convert.ToInt32(Console.ReadLine());
string[] array = EnterNewArray(size1);
Console.WriteLine("Ваш массив: ");
WriteArray(array);
string[] threeOrlessChar = Char3OrMore(array);
WriteArray(threeOrlessChar);