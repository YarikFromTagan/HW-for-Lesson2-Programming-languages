// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// Example:
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

int SecondDigit(int number)
{
    int dig = (number / 10) % 10;
    return dig;
}


Console.Write("Введите любое положительное трёхзначное число: ");

int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine($"Вторая цифра числа {num} --> {SecondDigit(num)}");
Console.WriteLine("");
