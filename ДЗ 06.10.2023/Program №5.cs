// стр. 31 №5
int Rabbit = 4;
int Goose = 2;
int n = 64;
int a, m, f;
f = n / Rabbit - 1;
for (int i = 1; i <= f ; i++ )
{
    a = i;
    m = (n - Rabbit * a) / Goose;
    Console.WriteLine($"Кроликов {a}, гусей {m}");
}
