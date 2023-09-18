// №6 стр.6
// Вычислить расстояние между двумя точками с заданными координатами (x1, y2) и (x2, y2)
Console.WriteLine("Ввдете первые координаты x1, y1");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввдете вторые координаты x2, y2");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

int r = Convert.ToInt32(Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 -y2), 2)));
Console.WriteLine($"Расстояние равно = {r}");
