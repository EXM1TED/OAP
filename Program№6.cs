// стр.20 №6
// Даны целые числа m, n. Если эти числа не равны, заменить меньшее из них большим исходным числом, а если равны, то заменить оба исходных числа нулями
Console.WriteLine("Введите чилсо m");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите чилсо n");
int n = Convert.ToInt32(Console.ReadLine());

if (m != n & n != m) 
{
    if (m > n)
    {
        Console.WriteLine($"Большое число {m}, меньшее {n}");
    } else
    {
        Console.WriteLine($"Большое число {n}, меньшее {m}");
    }
} else
{
    Console.WriteLine("Данные числа равны");
}

