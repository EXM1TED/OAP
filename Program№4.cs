// See https://aka.ms/new-console-template for more information
//Даны действительные числа x и y, не равные друг другу. Меньшее из этих двух чисел заменить половиной их суммы, а большие - их удвоенным произведением
Console.WriteLine("Введите число x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число y");
int y = Convert.ToInt32(Console.ReadLine());

int m = x;

if (x > y)
{
    x = 2 * x * y;
    y = (m + y) / 2;
} else
{
    x = (y + x) / 2;
    y = 2 * y * m;
}

Console.WriteLine($"{x}, {y}");