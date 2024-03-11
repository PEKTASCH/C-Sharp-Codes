int a, b = 2, c;

while (true)
{
    Console.WriteLine("Lütfen bir değer giriniz");
    a = Convert.ToInt32(Console.ReadLine());

    c = a % 2;

    if (c == 0)
    {
        Console.WriteLine("Sayı Çift");
    }

    else
    {
        Console.WriteLine("Sayı Tek");
    }
}