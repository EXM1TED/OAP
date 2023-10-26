/*           №22            */
Console.WriteLine("Введите длину последовательности");
int n = Convert.ToInt32(Console.ReadLine());

int a;

Console.WriteLine("Введите цифру, на которое будет оканчиваться число");
int b = Convert.ToInt32(Console.ReadLine());
int cifra;

int summa = 0;
Console.WriteLine("Введите числа последовательности");
for (int i = 0; i < n; i++)
{
    a = Convert.ToInt32(Console.ReadLine());
    cifra = a % 10;
    if (cifra == b)
    {
        summa += a;
    }
}
Console.WriteLine($"Сумма равна ={summa}");