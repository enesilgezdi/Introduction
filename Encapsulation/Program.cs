// Kullanıcının sisteme giriş yapılması isteniyor
// User -> FirstName, LastName, Email ,UserName, Password, FullName


using Encapsulation;

User user = new User()
{
    Name = "Enes",
    Lastname = "İlgezdi",
    Email = "enesilgezdi@gmail.com",
    Password = "123123",
    Username = "qwerty1"
};

Book book = new Book()
{
    Title = "Olasılıksız",
    Description = "Kumar bağımlılığı",
    AuthorName = "Adam",
    AuthorSurname = "Fawer",
    Publisher = "dota2 yayınevleri",
    PublishDate = "1965",

};

//Console.WriteLine(user);
Console.WriteLine(book);






// kitap -> Başlığı , Açıklaması , Yazar Adı, Yazar Soyadı,
// Yayın evi ,Basım Tarihi ,
//Yazar Tam adı,  (Yayın evi - Basım Tarihi)