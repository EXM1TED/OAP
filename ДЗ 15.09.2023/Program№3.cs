// №3 стр.6
// Вычислить длину окружности и площадь круга с заданным радиусом R
Console.WriteLine("Введите радиус R");
int R = Convert.ToInt32(Console.ReadLine());

int C = Convert.ToInt32(2 * Math.PI * R);
int S = Convert.ToInt32(Math.PI * Math.Pow(2, R));

Console.WriteLine($"Длина окружности равна = {C}");
Console.WriteLine($"Площадь круга равна = {S}");