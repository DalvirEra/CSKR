string[] array = new string[]{"hello","2","world",":-)","2134","-2"};
string[] array2 = new string[0];
for (int i = 0; i < array.Length; i++){
    if (array[i].Length < 4){
        array2 = ArrayAppenderLengher(array2,array[i]);
    }
}
PrintArray(array2);

// заменить существующий массив новым больше на 1 значение и заполнить.
// в теории старый должен стиратся из памяти.
string[] ArrayAppenderLengher(string[] ar,string str){
    string[] array = new string[ar.Length+1];
    ar.CopyTo(array,0);
    array[array.Length-1] = str;
    return array;
}

void PrintArray(string[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }   
    Console.WriteLine();
}