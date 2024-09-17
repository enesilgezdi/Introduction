string[] citys = { "istanbul", "izmir", "Ankara", "Mugla", "Balıkesir" };

//Console.WriteLine(citys[2]);

//Console.WriteLine("-------------------------------");

//for (int i = 0; i < citys.Length; i++)
//{
//    Console.WriteLine(citys[i]);
//}

//Console.WriteLine("-----------------------------");

//Console.WriteLine("foreach yöntemi");
//foreach (string city in citys) { Console.WriteLine(city); }


//ülkeler adında bir olusturun 5 tane elamn ekleyin
// görev 1: 2.elemanı bulunuz.
// görev 2: 2.indexteki elemanı gösteriniz.
// görev 3: for dongusu ile butun elemanları yazdır
// görev 4: foreach döngüsü ile bütün elemanları yazdır

//Console.WriteLine("****************************");


//string[] ulkeler = { "TÜRKİYE", "İSPANYA", "ARJANTİN", "İNGİLTERE", "JAPONYA" };

//Console.WriteLine(ulkeler[1]);
//Console.WriteLine(ulkeler[2]);



//Console.WriteLine("--------------------");


//for (int i = 0; i < ulkeler.Length; i++) Console.WriteLine(ulkeler[i]);

//Console.WriteLine("*************************");

//foreach (string ulke in ulkeler)
//{
//    Console.WriteLine(ulke);
//}



int[] numbers = { 1, 2, 3, 4, 9, 5, 6, 7, 88, 77, 100, 11 };

Array.Sort(numbers);
Array.Reverse(numbers);

foreach (var number in numbers)
{

    Console.WriteLine(number);
}


//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//}




//number dizisinden 4 ten büyük olanları ekran cıktısı veren kodu yazınız

//Array.Sort(numbers);

foreach (var number in numbers)
{
    if (number > 4)
    {
        Console.WriteLine($"4 ten büyük sayılar {number}");
    }
}

Console.WriteLine("**************************************");

// lambda yöntemi
Console.WriteLine("lambda expression yöntemi");
int[] filteredNumbers = Array.FindAll(numbers, x => x > 4);
Array.ForEach(filteredNumbers, x => Console.WriteLine(x));


Console.WriteLine("*****************************************************");
//Şehirler adında bir dizi olusturunuz 
// istanbul , malatya, Ankara, Eskişehir, Nevşehir, Erzurum
// Bu şehirler dizisinde şehir adlarında a harfi geçen şehirleri ekrana bastıran kodu yazınız

// lambda yönntemi

string[] sehirler = { "İstanbul", "Malatya", "Ankara", "Eskişehir", "Nevşehir", "Erzurum"};

string[] charFind = Array.FindAll(sehirler, x => x.Contains("a", StringComparison.InvariantCultureIgnoreCase));
Array.ForEach(charFind, x => Console.WriteLine(x));

//geleneksel yöntem

Console.WriteLine("geleneksel yontem **************************");

for (int j = 0; j < citys.Length; j++)
{
    if (citys[j].Contains("a", StringComparison.InvariantCultureIgnoreCase))
    {
        Console.WriteLine(citys[j]);
    }
}




int[] sayılar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

int[] tekSayılar = Array.FindAll(sayılar, x => x % 2 == 1);
int[] cıftSayılar = Array.FindAll(sayılar, x => x % 2 == 0);

Console.WriteLine("cift sayılar: ");
Array.ForEach(cıftSayılar, x => Console.WriteLine(x));

Console.WriteLine("tek sayılar: ");
Array.ForEach(tekSayılar, x => Console.WriteLine(x));



int i = 0;
while (i < sayılar.Length)
{
    Console.WriteLine(sayılar[i]);
    i++;
}

