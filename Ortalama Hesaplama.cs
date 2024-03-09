// Büt değişkeni kullanmadan ortalama hesaplama programı

float vize, final, ortalama;

bool gectiniz = false; // True - false değişkeni oluşturdum.

// Kullanıcıdan vize ve final notları alınacak

Console.WriteLine("Vize notunuzu giriniz: ");
vize = float.Parse(Console.ReadLine());

Console.WriteLine("Final notunuzu giriniz");
final = float.Parse(Console.ReadLine());

// Ortalama hesabı
ortalama = 0.4f * vize + 0.6f * final;
Console.WriteLine("Ortalama: " + ortalama);

if (final < 50 || ortalama < 50)
{
    Console.WriteLine("Bütünleme sınavına kaldınız.");

    Console.WriteLine("Bütünleme notunuzu giriniz: ");
    final = float.Parse(Console.ReadLine());

    ortalama = 0.4f * vize + 0.6f * final;

    if (final >= 50 && ortalama >= 50)   
    {
        gectiniz = true;
    }
}

else
{
    gectiniz = true;
}

// Geçme durumuna göre geri bildirim

if (gectiniz)
{
    Console.WriteLine("Tebrikler dersten geçtiniz! Ortalama notunuz: " + ortalama);
}

else
{
    Console.WriteLine("Kaldınız! Ortalama notunuz: " + ortalama);
}