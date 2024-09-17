

namespace Encapsulation;
// Firstname ve lastname minimum 2 haneli olmalıdır.
// Email @gmail.com ile bitmelidir.
// Password minimum 6 haneli olmalıdır
// Fullname'mi biz vericez kullanıcı değil.
public class User
{
    private string name;
    private string lastname;
    private string email;
    private string password;
    private string fullname;
    public string Name 
    {
        get
        {
            return name;
        }
        set
        {
            name = value;

            if ( name.Length < 2) {
                Console.WriteLine("name en az 2 haneli olmalıdır");
                return;
            }
            
        }
    }
    public string Lastname 
    {
        get { 
            return lastname;
        }
        set
        {
            lastname = value;
            if (lastname.Length < 2)
            {
                Console.WriteLine("lastname en az iki karakterli olmalıdır");
                return;
            }
        }
    }
    public string Email
    {
        get
        {
            return email;
        }

        set
        {
            email = value;
            if (email.EndsWith("@gamil.com"))
            {
                Console.WriteLine("@gmail.com ile bitmelidir");
               return ;
            }
        }
    }
    public string Password 
    {
        get
        {
            return password;
        }
        set
        {
            password = value;

            if( password.Length < 6)
            {
                Console.WriteLine("password 6 haneliden az olmamalıdır.");
                return;
            }
        }
            
    }
    public string Username { get; set; }
    public string Fullname
    {
        get
        {
            return $"{name} {lastname}";
        }
        set
        {
            fullname = $"{name} {lastname}";
        }
    }
    public override string ToString()
    {
        return $"Ad: {Name} soyAdı: {Lastname} Email : {Email} Password: {Password} " +
            $" Username : {Username} Fullname : {Fullname}";
    }
}
