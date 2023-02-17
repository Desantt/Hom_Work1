// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число ->");
string inputValue1 = Console.ReadLine();

Console.WriteLine("Введите второе число ->");
string inputValue2 = Console.ReadLine();

Console.WriteLine("Введите третье число ->");
string inputValue3 = Console.ReadLine();

int Value1 = Convert.ToInt32(inputValue1);
int Value2 = Convert.ToInt32(inputValue2);
int Value3 = Convert.ToInt32(inputValue3);

if (Value1 >= Value2 && Value1 >= Value3) 
{
    Console.WriteLine($"max = {Value1}");
}
else
if (Value2 >= Value3)
{
    Console.WriteLine($"max = {Value2}");   
}
else
{
    Console.WriteLine($"max = {Value3}");   
}



   
