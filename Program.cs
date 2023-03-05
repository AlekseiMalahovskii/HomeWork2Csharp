/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

/*
int MiddleNumber (int num)
{
    int hundreds = num / 100;
    int ones = num % 10;

    int result = (num - hundreds * 100 - ones) / 10;
    return result;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 || num > 999)
{
   Console.WriteLine("Input the correct number"); 
}
else 
{
int newNumber = MiddleNumber(num);
Console.WriteLine($"New version of {num} is {newNumber}");
}
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/*
int EndNumber (int num)
{
    while (num > 999)
{
    num = num / 10;
}
    int ones = num % 10;
    int result = ones;
    return result;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100)
{
   Console.WriteLine("Третьей цифры нет"); 
}
else
{
    int newNumber = EndNumber(num);
    Console.WriteLine($"Третьей цифрой числа {num} является {EndNumber(num)}");
}
*/

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

/*
bool Weekend (int Number)
{
    if(Number == 6 || Number == 7)
        return true;
    else
        return false;
}

Console.Write("Input number of the day of the week: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Weekend(num));

if (num < 1 || num > 7)
{
   Console.WriteLine("Input the correct number of the day of the week"); 
}
else 
{
    if (num == 6 || num == 7) 
    {
        Console.WriteLine("Hooray! Today is Weekend."); 
    }
    else
    {
        Console.WriteLine("Today is a work day.");
    }
}
*/