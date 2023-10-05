// стр. 38 №4 
Console.WriteLine("Введите длину последовательности");
int n = Convert.ToInt32(Console.ReadLine());
int a = 0;
int k = 0;

Console.WriteLine("Ввдеите число, которое будет повторяться");
int rep = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите числа последовательности");
for (int i = 0; i < n; i++)
{
    a = Convert.ToInt32(Console.ReadLine());
    if (a == rep) 
    {
        k++;
    }
}
Console.WriteLine($"Число повторяется {k} раз(а)");
