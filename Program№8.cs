// стр. 20 №8
//Определить количество положительных чисел в заданных числах a, b, c
Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число c");
int c = Convert.ToInt32(Console.ReadLine());

int k = 0;

if (a > 0)
{
    k = k + 1;
}

if (b > 0)
{
    k = k + 1;
}

if (c > 0)
{
    k = k + 1;
}

Console.WriteLine($"Колличество положительных чисел {k}");