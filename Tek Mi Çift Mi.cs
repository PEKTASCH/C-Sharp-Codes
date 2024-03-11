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


// Ayrıca bu algoritmayı da kullanabilirim. / I can also use this algorithm

/*
while (true)
{

    int sayi;

    Console.WriteLine("Bir sayi giriniz.");

    sayi = int.Parse(Console.ReadLine());

    if (sayi % 2 == 0)
    {

        Console.WriteLine("Sayi çifttir.");
    }

    else
    {

        Console.WriteLine("Sayi tektir.");
    }

}
*/