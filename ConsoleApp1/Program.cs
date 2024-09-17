// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// 1 den 4 e kadar kulanıcıdan bir sayı alınız rakamların karsılıgı

// 1-> ilkbahar
// 2 -> yaz 
// 3 -> sonbahar
// 4 -> kıs
//Console.WriteLine("Luften bir deger aralgi giriniz");
//int deger = Convert.ToInt32(Console.ReadLine());
//string mevsim = "";
// 1. yontem
//switch (deger)
//{
//    case 1:
//        mevsim = "ilkbahar";
//        break;
//    case 2:
//        mevsim = "Yaz";
//        break;
//    case 3:
//        mevsim = "SonBahar";
//        break;
//    case 4:
//        mevsim = "KIs";
//        break;

//        default:
//        Console.WriteLine("Yanlıs değer aralıgı girdiniz");
//        break;

//}



//mevsim = deger switch
//{
//    1 => "ilkbahar",
//    2 => "Yaz",
//    3 => "SonBahar",
//    4 => "KIs",
//    _ => "Geçersiz sayı gridiniz lüften 1 ile 4 arasında rakam giniz"
//};

//Console.WriteLine(mevsim);

// basit bir hesap makinasi uygulamsı yapnız(+,*,/,-,%,u(üs alma))

Console.WriteLine("Lüften bir sayı giriniz");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Luften ikinci sayıyı giriniz");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Yapmak istediğiniz işlemi seciniz (+,*,/,-,%,u(üs alma)) ");
string islem = Console.ReadLine(); 

double result = 0;

if(islem  == "+")
{
    result = number1 + number2;   
}else if (islem == "-")
{
    result = number1 - number2;
}else if(islem == "*")
{
    result = number1 * number2;
}else if(islem == "/"){
    result = number1 / number2;
}else if(islem == "%"){
    result = number1 % number2;
}else if(islem == "u"){
    result = Math.Pow(number1, number2);
}
else
{
    Console.WriteLine("luften dogru işlemi seçiniz");
}

//switch (islem)
//{
//    case "+":
//        result = number1 + number2;
//        break;
//    case "-":
//        result = number1 - number2;
//        break;
//    case "*":
//        result = number1 * number2;
//        break;
//    case "/":
//        result = number1 / number2;
//        break;
//    case "%":
//        result = number1 % number2;
//        break;
//    case "u":
//        result = Math.Pow(number1, number2);
//        break;

//    default:
//        Console.WriteLine("lutfen doru işlemi seçiniz");
//        break;

//}

//result = islem switch
//{
//    "+" => number2 + number1,
//    "-" => number2 - number2,
//    "*" => number1 * number1,
//    "/" => number1 / number2,
//    "%" => number1 % number2,
//    "u" => Math.Pow(number1, number2),
//};

Console.WriteLine(result);


Console.WriteLine("Kaç adet bilgi girmek istersiniz: ");
int adet = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < adet; i++)
{
    Console.WriteLine("Lütfen isim giriniz: ");
    string name = Console.ReadLine();

    Console.WriteLine("Lütfen soyisim giriniz: ");
    string surname = Console.ReadLine();

    Console.WriteLine("Lütfen yaşınızıgiriniz: ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"{i}. kişinin adı : {name}, soyadı: {surname}, yaşı:{age}");
}
