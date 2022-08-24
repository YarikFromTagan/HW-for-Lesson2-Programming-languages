// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
// 7 -> да
// 1 -> нет

void Saturday(int num6)
{
    Console.WriteLine("Это суббота - выходной день. :)");
    Console.WriteLine(" ");
}

void Sunday(int num7)
{
   Console.WriteLine("Это воскресенье - выходной день. :))");
   Console.WriteLine(" ");
}

void WorkAndWork(int num)
{
    Console.WriteLine("Не расстраивайтесь, но это пока ещё рабочий день");
    Console.WriteLine("Выходные не за горами :))))");
    Console.WriteLine(" ");
}

void DayMissing(int NotDay)
{
    Console.WriteLine($"Я не думаю, что Вам хотелось бы работать {NotDay - 2} дней в неделю");
    Console.WriteLine("и лишь только 2 дня отдыхать после этого :)))");
    Console.WriteLine(" ");
}

Console.Clear();
Console.Write("Введите любой порядковый номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");

if(day > 7) DayMissing(day);
else
    if(day == 6) Saturday(day);
    else
        if(day == 7) Sunday(day);
        else
            WorkAndWork(day);
   
