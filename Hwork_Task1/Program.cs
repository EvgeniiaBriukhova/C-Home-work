// Задача 1: Напишите программу, которая принимает 
// на вход число и проверяет, кратно ли оно одновременно 7 и 23.


Console.WriteLine("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("Yes, the number is divisible by both 7 and 23.");
}
else
{
    Console.WriteLine("No, the number is not divisible by both 7 and 23.");
}