// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 100, 999);
    PrintArray(array);
    System.Console.WriteLine(EvenNumbers(array));
}

int EvenNumbers(int[] arr)
{
int count = 0;

for (int i = 0; i < arr.Length; i++)
if (arr[i] % 2 == 0)
count++;

return count;
}

void PrintArray(int[] arrayForPrint)
{
for (int i = 0; i < arrayForPrint.Length; i++)
System.Console.Write(arrayForPrint[i] + " ");

System.Console.WriteLine();
}

int[] GenerateArray(int size, int minValue, int maxValue )
{
int[] tempArray = new int[size];
Random rand = new Random();

for (int i = 0; i < tempArray.Length; i++)
tempArray[i] = rand.Next(minValue, maxValue + 1);

return tempArray;
}

int ReadInt(string msg)
{
System.Console.Write(msg);
return Convert.ToInt32(Console.ReadLine()); 
}

Main();