
Student student2 = new Student();
student2.Name = "Test";
student2.Surname = "Test";
student2.Age = 19;
student2.Field = "test";
student2.Team = "arer";
student2.ProgrammingLanguages = "test";
student2.Number = "+905556445";
student2.KnowsForeignLanguage = true;
student2.District = "test";



Student student1 = new()
{
    Name = "Enes",
    Surname = "İLGEZDİ",
    Age = 12,
    Field = "Web Tam Donanım",
    Team = "Fenerbahçe",
    ProgrammingLanguages = "Javascript",
    Number = "+90533791980",
    KnowsForeignLanguage = true,
    District = "Bahçelievler",
};

Student student4 = new()
{
    Name = "Enes",
    Surname = "İLGEZDİ",
    Age = 14,
    Field = "Web Tam Donanım",
    Team = "Fenerbahçe",
    ProgrammingLanguages = "Javascript",
    Number = "+90533791980",
    KnowsForeignLanguage = true,
    District = "Bahçelievler",
};

Student student3 = new Student("enes", "ilgezdi", 30, "web", "fener", "test", "+905456544", true, "test");

//student1.DisplayInfo();

StudentManager.Add(student1);

StudentManager.Add(student2);

StudentManager.Add(student3);


StudentManager.Update(student1);


//Console.WriteLine(student4.ToString());

//student3.DisplayInfo(); 
class Student
{
    // Properties
    public string Name;
    public string Surname;
    public int Age;
    public string Field;
    public string Team;
    public string ProgrammingLanguages;
    public string Number;
    public bool KnowsForeignLanguage;
    public string District;

    // Empty Constructor
    public Student()
    {

    }

    // Full Constructor
    public Student(string name, string surname, int age, string field, string team, string programmingLanguages, string number, bool knowsForeignLanguage, string district)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Field = field;
        Team = team;
        ProgrammingLanguages = programmingLanguages;
        Number = number;
        KnowsForeignLanguage = knowsForeignLanguage;
        District = district;
    }

    // Display Method
    public void DisplayInfo()
    {
        Console.WriteLine($"Ad: {Name}");
        Console.WriteLine($"Soyad: {Surname}");
        Console.WriteLine($"Yaş: {Age}");
        Console.WriteLine($"Alan: {Field}");
        Console.WriteLine($"Tuttuğu Takım: {Team}");
        Console.WriteLine($"Bildikleri Programlama Dilleri: {string.Join(", ", ProgrammingLanguages)}");
        Console.WriteLine($"Numara: {Number}");
        Console.WriteLine($"Yabancı Dil: {KnowsForeignLanguage}");
        Console.WriteLine($"Semt: {District}");
    }

    // ToString Method Override
    public override string ToString()
    {
        return $"Ad: {Name}, Soyad: {Surname}, Yaş: {Age}, Alan: {Field}, Semt: {District}";
    }
}

class StudentManager
{

    // Constructor with Student
    //public StudentManager(Student student)
    //{
    //    this.student = student;
    //}

    // Add Method

    private static bool ValidateStudent(Student student)
    {
        if (student.Age < 18 || student.Age > 35)
        {
            Console.WriteLine("Öğrenci yaşı 18 ile 35 arasında olmalıdır.");
            return false;
        }

        if (string.IsNullOrWhiteSpace(student.Name) || student.Name.Length < 2)
        {
            Console.WriteLine("Ad en az 2 karakterli olmalıdır.");
            return false;
        }

        if (string.IsNullOrWhiteSpace(student.Surname) || student.Surname.Length < 2)
        {
            Console.WriteLine("Soyad en az 2 karakterli olmalıdır.");
            return false;
        }

        if (student.ProgrammingLanguages.Length < 1)
        {
            Console.WriteLine("Öğrenci en az bir programlama dili bilmelidir.");
            return false;
        }

        if (!student.Number.StartsWith("+905"))
        {
            Console.WriteLine("Numara +905 ile başlamalıdır.");
            return false;
        }

        if (string.IsNullOrWhiteSpace(student.District))
        {
            Console.WriteLine("Semt boş olamaz.");
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

        Console.WriteLine("******************************");
        Console.WriteLine("Öğrenci eklendi....");
        student.DisplayInfo();
        Console.WriteLine("******************************");
    }

    // Remove Method
    public static void Remove(Student student)
    {

        if (!ValidateStudent(student))
        {
            return;
        }
        Console.WriteLine("******************************");
        Console.WriteLine("Öğrenci silindi....");
        student.DisplayInfo();
        Console.WriteLine("******************************");
    }

    // Update Method
    public static void Update(Student student)
    {

        if (!ValidateStudent(student))
        {
            return;
        }
        Console.WriteLine("******************************");
        Console.WriteLine("Öğrenci güncellendi....");
        student.DisplayInfo();
        Console.WriteLine("******************************");
    }
}