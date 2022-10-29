class Program
{
    static void Main(string[] args)
    {
        var arrUsers = new Users[]
        {
            new Users("admin","admin",33432004),
            new Users("egor","password",32321999)
        };

    Start:
        Console.WriteLine("Чтобы авторизироваться введите 1, Чтобы зарегистрироваться введите 2");
        var input = Console.ReadLine();



        bool successfull = false;
        while (!successfull)
        {

            if (input == "1")
            {
                Console.WriteLine("Напишите имя пользователя::");
                var username = Console.ReadLine();
                Console.WriteLine("Введите свой пароль:");
                var password = Console.ReadLine();


                foreach (Users user in arrUsers)
                {
                    if (username == user.username && password == user.password)
                    {
                        Console.WriteLine("Вы успешно вошли в систему");
                        Console.ReadLine();
                        successfull = true;
                        break;
                    }
                }

                if (!successfull)
                {
                    Console.WriteLine("Ваш логин или пароль неверны, попробуйте еще раз!");
                }

            }

            else if (input == "2")
            {

                Console.WriteLine("Введите имя пользователя:");
                var username = Console.ReadLine();

                Console.WriteLine("Введите свой пароль:");
                var password = Console.ReadLine();

                Console.WriteLine("Введите свою дату рождения:");
                int id = int.Parse(Console.ReadLine());


                Array.Resize(ref arrUsers, arrUsers.Length + 1);
                arrUsers[arrUsers.Length - 1] = new Users(username, password, id);
                successfull = true;
                goto Start;

            }
            else
            {
                Console.WriteLine("Попробуйте еще раз!");
                break;


            }

        }

    }
}

public class Users
{
    public string username;
    public string password;
    private int id;

    public Users(string username, string password, int id)
    {
        this.username = username;
        this.password = password;
        this.id = id;
    }
}