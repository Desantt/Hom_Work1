// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите первое число ->");
string inputValue1 = Console.ReadLine();

int Value1 = Convert.ToInt32(inputValue1);

if (Value1 %2 ==0)
{
    Console.WriteLine($"Число {Value1} является чётным");
}
else
    {
    Console.WriteLine($"Число {Value1} является нечетным");   
    }
