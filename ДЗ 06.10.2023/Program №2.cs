// стр.31 №2
Console.WriteLine("Введите количество дней");
int S = Convert.ToInt32(Console.ReadLine());
int Dist = 10;

for (int i = 1; i <= S; i++)
{
    Dist++;
}
Console.WriteLine($"Суммарный путь спортсменна: {Dist}");