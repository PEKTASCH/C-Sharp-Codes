int satir, i, j;

Console.WriteLine("Satır Satısı Giriniz:");
satir = int.Parse(Console.ReadLine());

for (i = 0; i < satır+1; i++)
{
    
    for (j= 0; j< i; j++)
    {
        Console.Write("*");
    }   
    
    Console.WriteLine();   // Bir alt satıra inmesi için işlev
}