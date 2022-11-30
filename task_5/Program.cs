// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), выводящее это число в консоль вместе с правильным образом изменённым словом "программист", для того, чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.
Console.WriteLine("Введите количество программистов");
try
{

int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
numbProg(num);
}
catch
{
    Console.WriteLine("Ошибка выполнения");
}

void numbProg(int arg)
{
    string res = String.Empty;
    if (arg % 100 >= 10 && arg % 100 <= 14) res = "ов";
    else if (arg % 10 >= 2 && arg % 10 <= 4) res = "а";
    else if (arg % 10 == 1) res = "";
    else res = "ов";
    Console.WriteLine(arg + " программист" + res);
}