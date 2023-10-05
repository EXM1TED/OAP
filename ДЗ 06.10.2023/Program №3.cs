// стр.31 №3
int Cell = 1;
int Hours = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= Hours; i++)
{
        Cell = Hours / 3;
        Cell++;
}
Console.WriteLine($"Количество амеб: {Cell}");