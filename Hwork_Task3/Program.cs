// Задача 3: Напишите программу, которая принимает 
// на вход целое число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.

Console.WriteLine("Input your number from 10 to 99: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num >= 10 && num <= 99)
{
    int maxDigit = num % 10; 

        if (num / 10 > maxDigit)
        {
            maxDigit = num / 10;
        }
        Console.WriteLine($"The largest digit of a number {num} iqual to {maxDigit}.");
}
else
{
    Console.WriteLine("Input error!");
}