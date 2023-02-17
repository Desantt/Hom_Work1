Console.WriteLine("Введите число: ");              // вывод в консоль
string inputValue;                                 // Объявление переменой, в  которую будем сохранять переменную
inputValue = Console.ReadLine();           // Присваивание переменой из консоли (ввод пользователя)
int value = Convert.ToInt32(inputValue);        // Конвертация в целое введенной строки

int square = value * value;         //вычесление квадрата

// вывод на экран

System.Console.WriteLine("Квадрат числа " + value + " равен " + square);
System.Console.WriteLine($"Квадрат числа {value} равен {square}");