// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Razryad(int count)
{
    int i = 1;
    while(count / 10 != 0)
    {
        count = count / 10;
        i++;
    }
    return i;
}

int Dec(int stepen)
{
    int dec = 10;
    while(stepen != 1)
    {
        dec = dec * 10;
        stepen = stepen - 1;
    }
    return dec;
}

Console.Clear();
Console.Write("Введите любое целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(Razryad(num) <= 2)
{
    Console.WriteLine($"В числе {num} нет третьей цифры!");
}
else
{
    int exp = Razryad(num) - 2;
    int znam = Dec(exp);
    int ThirdDigit = (num % znam) / (znam / 10);
    
    Console.Write($"В числе {num} третья цифра ==> {ThirdDigit}");
}

