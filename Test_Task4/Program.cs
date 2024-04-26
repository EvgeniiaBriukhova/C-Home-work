//вводит натуральное числоб пишет его в строку и переворачивает.

// Console.Write("Input number N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// if (N < 10)
// {
// Console.WriteLine(N);
// }
// else
// {
// while (N > 0)
// {
// int currentDigit = N % 10;
// N /= 10;
// if (N > 0)
// {
// Console.Write(currentDigit + ",");
// }
// else
// {
// Console.WriteLine(currentDigit);
// }
// }
// }

//Вводит числобпишет его в строку через запятую.

Console.Write("Input number N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 0)
{
    Console.WriteLine("Input error - numer should be positive.");
}
else if (N < 10)
{
    Console.WriteLine(N);
}
else
{
    string numStr = N.ToString();
    Console.Write(numStr[0]); // Выводим первую цифрим последнюю цифру


// Выводим остальные цифры в обратном порядке, разделяя их запятой
    for (int i = 1; i < numStr.Length; i++)
    {
        Console.Write($",{numStr[i]}");
    }

    Console.WriteLine();
}