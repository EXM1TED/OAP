// стр. 20 №10
//Определить, делителем каких чисел a, b, c является число k
Console.WriteLine("Ввидете чилсо a");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввидете чилсо b");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввидете чилсо c");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввидете делитель k");
int k = Convert.ToInt32(Console.ReadLine());

if (a % k == 0)
{
    Console.WriteLine($"Число k является делителем для числа a: {a / k}");
}
else
{
    Console.WriteLine($"Число k не является делителем для числа a:  остаток {a % k}");
}

if (b % k == 0)
{
    Console.WriteLine($"Число k является делителем для числа b: {b / k}");
}
else
{
    Console.WriteLine($"Число k не является делителем для числа b: остаток {b % k}");
}

if (c % k == 0)
{
    Console.WriteLine($"Число k является делителем для числа c: {c / k}");
}
else
{
    Console.WriteLine($"Число k не является делителем для числа c: остаток {c % k}");
}