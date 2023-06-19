//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите неотрицательное число M: ");
string a = Console.ReadLine();

Console.Write("Введите неотрицательное число N: ");
string b = Console.ReadLine();

var numberM = ExceptionHandling(a);
var numberN = ExceptionHandling(b);

if (numberM.exception && numberN.exception && numberM.number >= 0 && numberN.number >= 0)
{
    Console.WriteLine($"A({numberM.number}, {numberN.number}) = {FunctionAkkerman(numberM.number, numberN.number)}");
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"{a}, {b} -> Некорректный ввод!");
}


int FunctionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return FunctionAkkerman(m - 1, 1);
    if (m > 0 && n > 0) return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
    return 0;
}

(bool exception, int number) ExceptionHandling(string number)
{
    bool yesInt = int.TryParse(number, out int d);
    if (!yesInt)
    {
        return (false, d);
    }
    return (true, d);
}