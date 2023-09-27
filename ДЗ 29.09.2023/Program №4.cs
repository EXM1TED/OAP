// стр. 28 №4
// Для каждой введенной цифры (0-9) вывести соотвестующее ей название на английском языке.
Console.WriteLine("Введите чилсло");
int a = Convert.ToInt32(Console.ReadLine());

while (a < 0 | a > 9)
{
    Console.WriteLine("Ошибка, введите число ещё раз");
    a = Convert.ToInt32(Console.ReadLine());
}

switch(a)
{
    case 0:
        Console.WriteLine("zero");
        break;
    case 1:
        Console.WriteLine("one");
        break;
    case 2:
        Console.WriteLine("two");
        break;
    case 3:
        Console.WriteLine("three");
        break;
    case 4:
        Console.WriteLine("four");
        break;
    case 5:
        Console.WriteLine("five");
        break;
    case 6:
        Console.WriteLine("six");
        break;
    case 7:
        Console.WriteLine("seven");
        break;
    case 8:
        Console.WriteLine("eight");
        break;
    case 9:
        Console.WriteLine("nine");
        break;
}
