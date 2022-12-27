// Задача 27: Напишите программу, которая принимает 
//на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
//Строки использовать нельзя

Console.WriteLine("Start");
int n = 9012;
int Sum = 0;
int i = 0;
while (n > 0)
{
    i = n % 10;
    Sum = Sum + i;  
    n = n / 10;
} 
    Console.WriteLine($"сумма цифр: {Sum}");
Console.WriteLine("END");
