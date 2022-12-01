// Напишите программу, которая выводит на экран числа от 1 до 100.
// При этом вместо чисел, кратных трем, программа должна выводить слово Fizz, а вместо чисел, кратных пяти — слово Buzz.
// Если число кратно пятнадцати, то программа должна выводить слово FizzBuzz.
// Задача может показаться очевидной, но нужно получить наиболее простое и красивое решение.
using System.Diagnostics;

string result =string.Empty;
string undRes =string.Empty;
Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();

// Стихийный способ:
for(int i=1;i<=100;i++)    
{
    if(i%3==0)
    {
       undRes=undRes+"Fizz";
        if (i%5==0)  undRes=undRes+"Buzz";
    }
    else if (i%5==0) undRes=undRes+"Buzz";
    else undRes=undRes+i;
    result=result+undRes+" ";
    undRes=string.Empty;
}
Console.Write(result);



stopWatch.Stop();
TimeSpan ts = stopWatch.Elapsed;
Console.WriteLine();
Console.WriteLine("Время выполнения: "+ts);