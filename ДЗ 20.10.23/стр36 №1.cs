// стр 36 №1 (б)
Console.WriteLine("Введите число eps");
double eps = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите длину числовой последоваетельности");
int n = Convert.ToInt32(Console.ReadLine());
double a;
double summa = 0;

for (int i = 0; i < n; i++)
{
    a = 1 / Math.Pow(2, n) + 1 / Math.Pow(3, n);
    if (a > eps)
    {
        summa += a;
    }
    Console.WriteLine(summa);
}
