// стр. 28 №5
// По заданному числу (1-12) вывести название соотвестующего месяца
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

while (a < 1 | a > 12)
{
    Console.WriteLine("Ошибка, ввдетите число ещё раз");
    a = Convert.ToInt32(Console.ReadLine());
}

switch (a)
{
    case 1:
        Console.WriteLine("Январь");
        break;
    case 2:
        Console.WriteLine("Февраль");
        break;
    case 3:
        Console.WriteLine("Март");
        break;
    case 4:
        Console.WriteLine("Апрель");
        break;
    case 5:
        Console.WriteLine("Май");
        break;
    case 6:
        Console.WriteLine("Июнь");
        break;
    case 7:
        Console.WriteLine("Июль");
        break;
    case 8:
        Console.WriteLine("Август");
        break;
    case 9:
        Console.WriteLine("Сентябрь");
        break;
    case 10:
        Console.WriteLine("Октябрь");
        break;
    case 11:
        Console.WriteLine("Ноябрь");
        break;
    case 12:
        Console.WriteLine("Декабрь");
        break;
}
