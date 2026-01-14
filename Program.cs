int c = 0;

void tambah (int a, int b)
{
    c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");
}
void kurang(int a, int b)
{
    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
}
void kali(int a, int b)
{
    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
}
void bagi(int a, int b)
{
    c = a / b;
    Console.WriteLine($"{a} / {b} = {c}");
}

tambah(6, 7);
kurang(19, 4);
tambah(20, 9);
kali(2, 5);
bagi(50, 5);



