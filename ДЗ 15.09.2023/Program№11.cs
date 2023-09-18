// №11 стр.6
// Найти площадь кольца, внутренний радиус которого равен r, а внешний - заданному числу R (R > r)
Console.WriteLine("Введите внутренний радиус r");
int r = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите внешний радиус R");
int R = Convert.ToInt32(Console.ReadLine());

int S = Convert.ToInt32(Math.PI*(Math.Pow(R,2) - Math.Pow(r,2)));
Console.WriteLine($"Площадь равна кольца = {S}");