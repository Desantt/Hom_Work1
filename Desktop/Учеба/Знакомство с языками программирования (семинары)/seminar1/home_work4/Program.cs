// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите первое число ->");
string evennum = Console.ReadLine();
int num = Convert.ToInt32(evennum);
int count = 1;
while(count< num)
{
     System.Console.Write($"{count +1} |");
    count+=2;
}