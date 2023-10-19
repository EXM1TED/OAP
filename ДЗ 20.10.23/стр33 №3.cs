// стр. 33 №3 
Console.WriteLine("Введите натуральное число N");
int N = Convert.ToInt32(Console.ReadLine());
double P = 1.0;
double multip = 1.0;

for (int i = 1; i <= N ;i++)
{
    P = (2.0 * i) / (2 * i + 1);
    multip = P * multip;
    Console.WriteLine(multip);
}

