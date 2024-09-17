
//•	Student adında bir class oluşturunuz
//•	StudentManager adında bir class oluşturunuz.

//Student:
//•	İsim, Soyisim, Yaş, Alan, Tuttuğu takım , bildikleri programlama dilleri, Numara, Yabancı Dil Biliyormu(bool), Semt


//•	ToString() kullanınız.
//•	Boş constructor ve dolu constructor oluşturunuz.



//StudentManager:
//•	Add(Student student);
//•	Update(Student student);
//•	Remove(Student student);

//Ekleme ve güncelleme işlemi yapılırken şu kurallar olmalıdır.
//•	Öğrenci adı ve Soyadı minimum 2 karakterli olmalıdır.
//•	Programlama dillerinden en az 1 tane bilmelidir.
//•	Öğrenci yaşı 35 den az 18 den büyük eşit olmalıdır.
//•	Numarası boş olmamalı ve +905 ile başlamalı
//•	Semt alanı boş olmamalı



Student student = new Student()
{
    Name = "ENES",
    LastName = "ilgezdi",
    Age = 12,
    Field = "Web tam donanım",
    Team = "Fenerbahçe",
    ProgramLanguage = "JavaScript",
    PhoneNumber = "+9053379192",
    DoyouKnowLanguage = true,
    District = "Bahçelievler"
};

Console.WriteLine(student);

StudentManager.Add(student);


class Student
{
    public string Name;
    public string LastName;
    public int Age;
    public string Field;
    public string Team;
    public string ProgramLanguage;
    public string PhoneNumber;
    public bool DoyouKnowLanguage;
    public string District;

    public Student()
    {
        // Bos constraktor
    }

    public Student(string name , string lastname , int age , 
        string field , string team , string programlanguage, string phoneNumber, 
        bool language ,string district)
    {
        Name = name;
        LastName = lastname;
        Age = age;
        Field = field;
        Team = team;
        ProgramLanguage = programlanguage;
        PhoneNumber = phoneNumber;
        DoyouKnowLanguage = language;
        District = district;
    }

   
   

    public override string ToString()
    {
        return $"Ad: {Name}, Soyad: {LastName}, Yaş: {Age}, Alan: {Field}, Semt: {District}";
    }

}


class StudentManager
{

    private static bool ValidateStudent(Student student)
    {
        if (student.Name.Length < 2)
        {
            Console.WriteLine("lütfen 2 den fazla karrater girin");
            return false;
        }
        if(student.LastName.Length < 2)
        {
            Console.WriteLine("lutfen 2den fazla karakter girin");
            return false;
        }

        if(student.ProgramLanguage.Length < 1)
        {
            Console.WriteLine("En az bir dil bilmelidir");
            return false;
        }   

        if(student.Age<18 || student.Age > 35)
        {
            Console.WriteLine("18den kcük ve 35 ten byük olamaz");
            return false;
        }
        if(string.IsNullOrEmpty(student.PhoneNumber) && student.PhoneNumber.StartsWith("+905"))
        {
            Console.WriteLine("telofon numarası +905 ile baslamaldır");
            return false;
        }

        if (string.IsNullOrEmpty(student.District)){
            Console.WriteLine("Semt adı bos olmamalı");
            return false;
        }

        return true;
    }
    public static void Add(Student student)
    {
        if (!ValidateStudent(student))
        {
            return;
        }
        Console.WriteLine("Ögrenci eklendi");

    }

    public static void Remove(Student student)
    {
        if (!ValidateStudent(student))
        {
            return;
        }
        Console.WriteLine("Ögrenci silindi");
    }

    public static void Update(Student student) {
        if (!ValidateStudent(student))
        {
            return;
        }

        Console.WriteLine("Ögrenci Güncellendi");
    }
}