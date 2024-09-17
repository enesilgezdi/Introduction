

//string[] ogrenciler = new string[3];
//int[] notlar = new int[3];

//// Öğrencilerin isim ve notlarını al
//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine($"{i + 1}. öğrenci: ");
//    ogrenciler[i] = Console.ReadLine();
//    Console.WriteLine($"{i + 1}. öğrenci notu: ");
//    notlar[i] = Convert.ToInt32(Console.ReadLine());
//}

//// Öğrenci isimleri ve notlarını yan yana yazdır
//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine($"Öğrenci: {ogrenciler[i]} - Notu: {notlar[i]}");
//}


//int userAge = 19;

//if(userAge< 18)
//{
//    Console.WriteLine("ehliyet alamaz");
//}
//else if(userAge > 18)
//{
//    Console.WriteLine("ehliyet alır");
//}



//if (userAge % 2 == 0)
//{
//    Console.WriteLine("cift sayı");
//}
//else
//{
//    Console.WriteLine("tek sayı");
//}


Console.WriteLine("Toplama için: +");
Console.WriteLine("Cıkarma için: -");
Console.WriteLine("Bölme için: /");
Console.WriteLine("Carpma için: *");

Console.WriteLine("Seçiminiz : ");
var secim = Console.ReadLine();


if(secim != null)
{
    Console.WriteLine("luften doru şecimi yapıız ' +, -, *, /'");
    return;
}



Console.WriteLine("1. sayı: ");
var sayi1  = Convert.ToInt32( Console.ReadLine());

Console.WriteLine("2. sayı: ");
var sayi2 = Convert.ToInt32(Console.ReadLine());




if( secim == "+")
{
    var toplam = sayi1 + sayi2;
    Console.WriteLine(toplam);
}else if ( secim == "-")
{
    var fark = (sayi1 - sayi2);
    Console.WriteLine(fark);
}
else if ( secim == "*")
{
    var carpma = (sayi1 * sayi2);
    Console.WriteLine(carpma);
}
else if( secim == "/")
{
    var bolme = (sayi1 / sayi2);
    Console.WriteLine(bolme);
}
else
{
    Console.WriteLine("yanlıs şeçim yaptınız !!!!");
}

