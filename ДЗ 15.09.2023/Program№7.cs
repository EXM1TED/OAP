// №7 стр.6 
//Даны два действительных числа x и y. Вычислить их сумму, разность, произведение, и частное
Console.WriteLine("Введите чилсо x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите чилсо y");
int y = Convert.ToInt32(Console.ReadLine());

int sum = x + y;
int diff = x - y;
int multip = x * y;
int quotient = x / y;

double quotient2 = x / y;

Console.WriteLine($"Сумма x+y = {sum}");
Console.WriteLine($"Разность x-y = {diff}");
Console.WriteLine($"Произведение x*y = {multip}");
Console.WriteLine($"Частное x/y = {quotient}");
Console.WriteLine($"Вещественное  = {quotient2}");

