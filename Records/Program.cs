using Records;

Category category = new Category(
    1, "Bilgisayar", "Bilgisayar açıklaması"
);

Product product = new Product(
    Name: "Msi bilgisayar",
    Price: 25000,
    Stock: 250,
    Description: "cok fenaa :)",
    Category: category
 );


Console.WriteLine(product);
