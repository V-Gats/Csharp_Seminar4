// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

void Main()
{
int arraySize = ReadInt("Введите размер массива: ");
int[] array = GenerateArray(arraySize, 1, 100);
PrintArray(array);
int[] recursiy = RecursiyArray(array, arraySize);
System.Console.WriteLine(string.Join("," , recursiy));
}

int[] RecursiyArray(int[] array, int size)
{
    int[] pom = new int[size];
    int j = size - 1 ;
    for(int i = 0; i < array.Length; i ++ , j--)
    {
    pom[j] = array[i];
    }

    return pom;

    ;
} 

void PrintArray(int[] arrayForPrint)
{
for (int i = 0; i < arrayForPrint.Length; i++)
System.Console.Write(arrayForPrint[i] + " ");

System.Console.WriteLine();
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
int[] tempArray = new int[size];
Random rand = new Random();

for (int i = 0; i < tempArray.Length; i++)
tempArray[i] = rand.Next(minValue, maxValue);

return tempArray;
}

int ReadInt(string msg)
{
System.Console.Write(msg);
return Convert.ToInt32(Console.ReadLine()); 
}

Main();