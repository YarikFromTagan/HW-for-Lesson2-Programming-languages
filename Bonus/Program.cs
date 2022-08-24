/* Написать программу, которая принимает на вход два числа
и проверяет является ли одно число квадратом другого (вернуть bool)*/

bool CheckSqr(int num1, int num2)
{
    if(num1 == num2 * num2) return true;
    if(num2 == num1 * num1) return true;
        else return false;
}

Console.Clear();
Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine();

bool result = CheckSqr(a, b);

if(result) Console.WriteLine("Одно из введеных чисел является квадратом второго");
    else Console.WriteLine("!!! Одно из введеных чисел НЕ является квадратом второго !!!");

Console.WriteLine();