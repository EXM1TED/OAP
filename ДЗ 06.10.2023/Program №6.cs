// стр. 38 №6
Console.WriteLine("Введите длину последовательности");
int n = Convert.ToInt32(Console.ReadLine());
int a = 0;
int multip = 1;

Console.WriteLine("Введите числа последотваельности");
for (int i = 0; i < n; i++)
{
    a = Convert.ToInt32(Console.ReadLine());
    multip = multip * a;
}
Console.WriteLine($"Произведение чисел последовательности равно: {multip}");