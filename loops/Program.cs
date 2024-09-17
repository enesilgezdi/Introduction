// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//Console.WriteLine("Kaç adet bilgi girmek istersiniz: ");
//int adet = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < adet; i++)
//{
//    Console.WriteLine("Lütfen isim giriniz: ");
//    string name = Console.ReadLine();

//    Console.WriteLine("Lütfen soyisim giriniz: ");
//    string surname = Console.ReadLine();

//    Console.WriteLine("Lütfen yaşınızıgiriniz: ");
//    int age = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine($"{i + 1}. kişinin adı : {name}, soyadı: {surname}, yaşı:{age}");
//}

//Kullanıcının bakiyesi 35000 tldir alacağı ürünler listesi şu şekildedir 
//* Bilgisayar 10000
//* Telefon 5000
//* Klavye 1500
//Burada hangi üründen kaç tane alacaksa adet sayısı ve ürünün fiyatı çarpılarak her bir ürün için toplam değeri hesaplanacak koşullar 
//* Kullanıcının toplam hesabı 20 bin den fazla ise % 20 indirim yapılacak 
//* 30 bin den fazla 35 binden az ise  %30 yapılacak
//* eğer total ücret 35 bini aşarsa yetersiz bakiye ekran çıktısını versin 

//İsterler 
//* eğer indirim uygulanacaksa indirimli ve indirimsiz fiyatını ekran çıktısı olarak veriniz.


// Kullanıcı bakiyesi
//double bakiye = 35000;

//// Ürünlerin fiyatları
//double bilgisayarFiyat = 10000;
//double telefonFiyat = 5000;
//double klavyeFiyat = 1500;

//// Kullanıcıdan her bir üründen kaç tane almak istediğini öğrenelim
//Console.Write("Kaç adet bilgisayar almak istiyorsunuz? ");
//int bilgisayarAdet = Convert.ToInt32(Console.ReadLine());

//Console.Write("Kaç adet telefon almak istiyorsunuz? ");
//int telefonAdet = Convert.ToInt32(Console.ReadLine());

//Console.Write("Kaç adet klavye almak istiyorsunuz? ");
//int klavyeAdet = Convert.ToInt32(Console.ReadLine());

//// Her bir ürün için toplam fiyatı hesaplayalım
//double toplamFiyat = (bilgisayarFiyat * bilgisayarAdet) +
//                     (telefonFiyat * telefonAdet) +
//                     (klavyeFiyat * klavyeAdet);

//// İndirim ve toplam hesaplama
//double indirimliFiyat = toplamFiyat;


//if(toplamFiyat < 20000)
//{
//    Console.WriteLine("Toplam Fiyat: " + toplamFiyat + " TL");
//}
//else if (toplamFiyat > 20000 && toplamFiyat <= 30000)
//{
//    // %20 indirim
//    indirimliFiyat = toplamFiyat * 0.80;
//    Console.WriteLine($"Tutar : {toplamFiyat} TL");
//    Console.WriteLine("İndirimli Fiyat: " + indirimliFiyat + " TL");
//}
//else if (toplamFiyat > 30000 && toplamFiyat < 35000)
//{
//    // %30 indirim
//    indirimliFiyat = toplamFiyat * 0.70;
//    Console.WriteLine($"Tutar : {toplamFiyat} TL");
//    Console.WriteLine("İndirimli Fiyat: " + indirimliFiyat + " TL");
//}
//else if (toplamFiyat > 35000)
//{
//    // Yetersiz bakiye durumu
//    Console.WriteLine("Yetersiz bakiye.");
//    Console.WriteLine($"Bakiyeniz : {bakiye}  Tutar : {toplamFiyat}");
//    return;
//}




//Kullanıcının bakiyesi 35000 tldir alacağı ürünler listesi şu şekildedir 
//* Bilgisayar 10000
//* Telefon 5000
//* Klavye 1500
//Burada hangi üründen kaç tane alacaksa adet sayısı ve ürünün fiyatı çarpılarak her bir ürün için toplam değeri hesaplanacak koşullar 
//* Kullanıcının toplam hesabı 20 bin den fazla ise % 20 indirim yapılacak 
//* 30 bin den fazla 35 binden az ise  %30 yapılacak
//* eğer total ücret 35 bini aşarsa yetersiz bakiye ekran çıktısını versin 

double bakiye = 35000;

double pcPrice = 10000;
double phonePrice = 5000;
double keyboardPrice = 1500;

Console.WriteLine("Kaç adet pc satın almak istersiniz ? ");
int pcAdet = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Kaç adet phone satın almak istersiniz ? ");
int phoneAdet = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Kaç adet keyboard satın almak istersiniz ? ");
int keyboardAdet = Convert.ToInt32(Console.ReadLine());


double toplamFiyat = (pcPrice * pcAdet) + ( phonePrice * phoneAdet) + (keyboardPrice * keyboardAdet);

double discounted = toplamFiyat;


if(toplamFiyat < 20000)
{
    Console.WriteLine($"Aldıgınız ürünlerin toplam Tutarı : {toplamFiyat} TL");
    Console.WriteLine($"Kalan bakiye: {bakiye - toplamFiyat} TL");

}else if (toplamFiyat >=20000 && toplamFiyat < 30000)
{
    discounted = toplamFiyat * 0.80;
    Console.WriteLine($"Toplam Fiyat: {toplamFiyat} TL");
    Console.WriteLine($"İndirimli Fiyat: {discounted} TL");
    Console.WriteLine($"Kalan bakiye: {bakiye - discounted} TL");

}else if(toplamFiyat >= 30000 && toplamFiyat <=35000)
{

    discounted = toplamFiyat * 0.70;
    Console.WriteLine($"Toplam Fiyat: {toplamFiyat} TL");
    Console.WriteLine($"İndirimli Fiyat: {discounted} TL");
    Console.WriteLine($"Kalan bakiye: {bakiye - discounted} TL");
}else if(toplamFiyat > 35000)
{
    Console.WriteLine($"Yetersiz bakiye : {toplamFiyat}TL");
    Console.WriteLine($"Bakiyeniz : {bakiye}");

    return;
}