//стр. 41 №1
using System.Runtime.Intrinsics.Arm;

Console.WriteLine("Введите натуральное число n");
int n = Convert.ToInt32(Console.ReadLine());
int summa = 0;
double lastNumber = n % 10;
while (n > 0)
{
    n = n / 10;
    summa += n / 10;
}
Console.WriteLine(summa + lastNumber);