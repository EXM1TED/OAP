// №5 стр.6
// Даны два числа. Найти среднее арифмитическое кубов и среднее геометрическое модулей этих чисел
Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите чилсло b");
int b = Convert.ToInt32(Console.ReadLine());

int Sr1 = ((a * a * a) + (b * b * b)) / 2;
double Sr2 = Convert.ToDouble((a * a * a) + (b * b * b)) / 2;

int Sg = Convert.ToInt32(Math.Sqrt(Math.Abs(a) * Math.Abs(b)));

Console.WriteLine($"Среднее арифмитическое число {Sr1}");
Console.WriteLine($"Вещественное среднее арифмитическое число {Sr2}");
Console.WriteLine($"Среднее геометрическое число {Sg}");