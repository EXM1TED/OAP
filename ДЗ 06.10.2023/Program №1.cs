// стр.38 №1
Console.WriteLine("Введите длину последовательности");
int n = Convert.ToInt32(Console.ReadLine());
int a = 0;
int summa = 0;

Console.WriteLine("Введите числа последовательности");
for (int i = 0; i < n; i++)
{
    a = Convert.ToInt32(Console.ReadLine());
    summa = summa + a;
}
Console.WriteLine($"Сумма чисел последовательности = {summa}");