// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.


void Main()
{
    bool exit = true;

    while(exit)
    {

    int input = ReadInt("Введите число: ");
    int sum = Sum(input);
    char simbol = ConToChr(input);

    if (sum % 2 == 0 || simbol == 'q')
    {
    System.Console.WriteLine("Выход");
    exit = false;
    }
    
    
    }
}


char ConToChr(int number)
{
    char symbol = Convert.ToChar(number);
    return symbol;
}



int Sum(int number)
{
    int sum = 0;
    while (number % 10 > 0 )
    {
        sum += number % 10;
        number /= 10;
    }

    return sum;
}

int ReadInt(string msg)
{
System.Console.Write(msg);
return Convert.ToInt32(Console.ReadLine());
}



Main();
System.Console.ReadKey();