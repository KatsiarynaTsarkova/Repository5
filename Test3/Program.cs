// Программа задает массив из 8 элементов и выводит их на экран
int[] FillArrayNumber(int[] array)
{
    for( int i = 0; i < array.Length; i++) 
    {
        array[i] = new Random().Next(1, 10);
    }
return array;
}

void WriteArrayPrint(int[] array)
{
    for( int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    } 
}
int[] numbers = FillArrayNumber(new int[8]);
WriteArrayPrint(numbers);


