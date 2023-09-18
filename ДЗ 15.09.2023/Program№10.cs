// №10 стр.6
// Известна длина окружности. Найти площадь круга, ограниченнрого этой окружностью.
Console.WriteLine("Введите дилну окружности");
int C = Convert.ToInt32(Console.ReadLine());

double R = Convert.ToDouble(C / (2 * Math.PI));
double S = Convert.ToDouble(2 * Math.PI * Math.Pow(R, 2));

Console.WriteLine($"Площадь круга равна = {S}");
