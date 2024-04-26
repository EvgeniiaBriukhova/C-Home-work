// Задача 4: Напишите программу, которая на вход 
// принимает натуральное число N, а на выходе показывает 
// его цифры через запятую.


Console.WriteLine("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The digits of the number {num} are separated by commas: ");

string numStr = num.ToString();
Console.Write(numStr[0]);

for (int i = 1; i < numStr.Length; i++)
{
    Console.Write($",{numStr[i]}");
}
Console.WriteLine();