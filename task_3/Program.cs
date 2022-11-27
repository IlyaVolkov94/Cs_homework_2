//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Ведите цифру дня недели");
void WeekDay(int arg)
{
    if (arg == 6 || arg == 7) Console.WriteLine("Ура! Выходной!");
    else if (arg >= 1 && arg <= 5) Console.WriteLine("Опять на работу :(");
    else Console.WriteLine("Нет такого дня");
}

try
{
    int numWeek =Convert.ToInt32(Console.ReadLine());
    WeekDay(numWeek);
}
catch
{
    Console.WriteLine("Ошибка выполнения");
}