// стр.28 №6
// Получить словесное описание школьных отметок
Console.WriteLine("Ввдеите оценку: ");
int a = Convert.ToInt32(Console.ReadLine());

while (a < 1 | a > 5)
{
    Console.WriteLine("Ошибка, введите число ещё раз");
    a = Convert.ToInt32(Console.ReadLine());
}

switch (a)
{
    case 1:
        Console.WriteLine("Плохо");
        break;
    case 2:
        Console.WriteLine("Неудовлетворительно");
        break;
    case 3:
        Console.WriteLine("Удовлетворительно");
        break;
    case 4:
        Console.WriteLine("Хорошо");
        break;
    case 5:
        Console.WriteLine("Отлично");
        break;
}
